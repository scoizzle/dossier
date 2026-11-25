using System.Collections.Concurrent;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using Microsoft.Data.Sqlite;

namespace Dossier;

/// <summary>
/// Minimal read-only web UI and JSON API, bound to loopback only (127.0.0.1, plus the
/// <c>localhost</c> name when every address it resolves to is loopback and the first of them can be
/// bound). The managed HttpListener rejects bracketed IPv6 prefixes, so <c>[::1]</c> is reached
/// through the <c>localhost</c> prefix where that resolves to ::1. Every endpoint calls the same
/// core entry points as the CLI and MCP transports.
/// </summary>
public sealed class WebServer : IDisposable
{
    /// <summary>Concurrent event streams per server; the next one gets <c>503 busy</c>.</summary>
    private const int MaxEventStreams = 8;

    /// <summary>Journal rows per <c>changes</c> frame.</summary>
    private const int ChangePageSize = 200;

    /// <summary>Journal rows one tick may deliver before the client is told to reset instead.</summary>
    private const int ChangeDrainCap = 5000;

    private static readonly TimeSpan DefaultRevisionPollInterval = TimeSpan.FromMilliseconds(500);
    private static readonly TimeSpan DefaultKeepaliveInterval = TimeSpan.FromSeconds(5);

    /// <summary>The SSE preamble: EventSource reconnects after one second.</summary>
    private static readonly byte[] RetryFrame = Encoding.UTF8.GetBytes("retry: 1000\n\n");

    /// <summary>A comment line long enough to keep idle proxies from closing the stream.</summary>
    private static readonly byte[] KeepaliveFrame = Encoding.UTF8.GetBytes(": keepalive " + new string(' ', 1024) + "\n\n");

    private readonly DossierStore store;
    private readonly HttpListener listener = new();
    private readonly TimeSpan revisionPollInterval;
    private readonly CancellationTokenSource shutdown = new();
    private readonly ConcurrentDictionary<Task, byte> handlers = new();

    private readonly object revisionLock = new();
    private long revision;
    private TaskCompletionSource revisionChanged = NewSignal();

    private Task? loop;
    private Task? poller;
    private int openStreams;
    private int stopped;

    /// <param name="revisionPollInterval">
    /// How often the background poller reads <see cref="DossierStore.Revision"/>. Short values keep tests
    /// fast; the default is what a person running <c>dossier serve</c> gets.
    /// </param>
    public WebServer(DossierStore store, int port, TimeSpan? revisionPollInterval = null)
    {
        this.store = store;
        this.revisionPollInterval = revisionPollInterval ?? DefaultRevisionPollInterval;
        Port = port;
        listener.Prefixes.Add($"http://127.0.0.1:{port}/");
        if (ShouldAddLocalhostPrefix(ResolveLocalhost(), CanBind))
        {
            listener.Prefixes.Add($"http://localhost:{port}/");
        }
        else
        {
            Console.Error.WriteLine("warning: 'localhost' is not served (it does not resolve solely to bindable loopback addresses); serving 127.0.0.1 only");
        }
    }

    private static IPAddress[] ResolveLocalhost()
    {
        try
        {
            return Dns.GetHostAddresses("localhost");
        }
        catch (Exception exception) when (exception is SocketException or ArgumentException)
        {
            return [];
        }
    }

    /// <summary>
    /// Registers the <c>localhost</c> prefix only when the name is safe and usable: it resolved to at
    /// least one address, every address is loopback, and the first address (the one the prefix binds)
    /// can actually be listened on. On a host where localhost resolves to ::1 first but IPv6 loopback
    /// cannot be bound, registering the prefix would make <see cref="Start"/> throw; skipping it keeps
    /// 127.0.0.1 serving.
    /// </summary>
    internal static bool ShouldAddLocalhostPrefix(IPAddress[] addresses, Func<IPAddress, bool> canBind) =>
        addresses.Length > 0 && addresses.All(IPAddress.IsLoopback) && canBind(addresses[0]);

    /// <summary>Binds a throwaway socket to the address on an ephemeral port to see if it is usable.</summary>
    private static bool CanBind(IPAddress address) => CanBind(address, CreateSocket);

    /// <summary>The production socket factory: one TCP socket for the address's own family.</summary>
    private static Socket CreateSocket(IPAddress address) => new(address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

    /// <summary>
    /// Both the socket creation and the bind sit inside the try: on a host where <c>localhost</c>
    /// resolves to ::1 but IPv6 sockets cannot be created, the constructor itself throws. Any
    /// socket-level failure means the address is not usable, so the probe answers false instead of
    /// letting the exception escape <see cref="ShouldAddLocalhostPrefix"/> and the constructor.
    /// </summary>
    internal static bool CanBind(IPAddress address, Func<IPAddress, Socket> createSocket)
    {
        Socket? socket = null;
        try
        {
            socket = createSocket(address);
            socket.Bind(new IPEndPoint(address, 0));
            return true;
        }
        catch (Exception exception) when (exception is SocketException or PlatformNotSupportedException or NotSupportedException)
        {
            return false;
        }
        finally
        {
            socket?.Dispose();
        }
    }

    /// <summary>
    /// Defense in depth only. The real DNS-rebinding protection is that no wildcard (+ or *) prefix
    /// is ever registered: HttpListener matches the Host header against the registered loopback
    /// prefixes and answers anything else itself. This checks the raw Host header: loopback name
    /// (localhost, 127.0.0.1, [::1]) with the serve port or no port. A missing Host (HTTP/1.0) is
    /// accepted because the sockets are loopback-bound.
    /// </summary>
    internal static bool IsLoopbackHost(string? hostHeader, int port)
    {
        if (string.IsNullOrEmpty(hostHeader))
        {
            return true;
        }

        string name = hostHeader;
        string? portText = null;
        if (hostHeader.StartsWith('['))
        {
            var close = hostHeader.IndexOf(']');
            if (close < 0)
            {
                return false;
            }

            name = hostHeader[..(close + 1)];
            var rest = hostHeader[(close + 1)..];
            if (rest.Length > 0)
            {
                if (rest[0] != ':')
                {
                    return false;
                }

                portText = rest[1..];
            }
        }
        else
        {
            var colon = hostHeader.IndexOf(':');
            if (colon >= 0)
            {
                name = hostHeader[..colon];
                portText = hostHeader[(colon + 1)..];
            }
        }

        if (portText is not null && !(int.TryParse(portText, System.Globalization.NumberStyles.None, System.Globalization.CultureInfo.InvariantCulture, out var parsed) && parsed == port))
        {
            return false;
        }

        return name.Equals("localhost", StringComparison.OrdinalIgnoreCase) || name == "127.0.0.1" || name == "[::1]";
    }

    public int Port { get; }

    /// <summary>
    /// Test seam: the counter read behind the poller. A reader that throws is how a test proves the
    /// poll loop survives an exception it does not name.
    /// </summary>
    internal Func<long>? RevisionReader { get; set; }

    /// <summary>
    /// Test seam: the journal read behind an event stream. A reader that throws is how a test proves a
    /// failing journal read skips one tick instead of ending the stream.
    /// </summary>
    internal Func<long, int, ChangesPage>? ChangesReader { get; set; }

    /// <summary>
    /// How long an idle stream waits before writing a keepalive comment (and retrying a journal read
    /// that failed). Short values keep tests fast; the default is what a person running
    /// <c>dossier serve</c> gets.
    /// </summary>
    internal TimeSpan KeepaliveInterval { get; set; } = DefaultKeepaliveInterval;

    public void Start()
    {
        // Read once here so a stream opened before the first poll already has a truthful baseline.
        revision = ReadRevision();
        listener.Start();
        loop = Task.Run(Loop);
        poller = Task.Run(PollRevisionAsync);
    }

    public void Stop()
    {
        if (Interlocked.Exchange(ref stopped, 1) != 0)
        {
            return;
        }

        try
        {
            shutdown.Cancel();
        }
        catch (ObjectDisposedException)
        {
        }

        try
        {
            if (listener.IsListening)
            {
                listener.Stop();
            }
        }
        catch (ObjectDisposedException)
        {
        }

        try
        {
            loop?.Wait(TimeSpan.FromSeconds(5));
        }
        catch (AggregateException)
        {
        }

        var running = handlers.Keys.ToArray();
        if (running.Length > 0)
        {
            try
            {
                Task.WaitAll(running, TimeSpan.FromSeconds(2));
            }
            catch (AggregateException)
            {
            }
        }

        try
        {
            poller?.Wait(TimeSpan.FromSeconds(2));
        }
        catch (AggregateException)
        {
        }

        try
        {
            listener.Close();
        }
        catch (ObjectDisposedException)
        {
        }
        catch (HttpListenerException)
        {
            // Stop() above already removed every prefix and closed its endpoints. Close() walks the
            // prefixes again, and HttpEndPointManager.RemovePrefixInternal opens a fresh endpoint
            // socket for each just to remove a prefix that is no longer registered; on a port that a
            // lingering TIME_WAIT connection (or another process) still holds, that bind fails with
            // "Address already in use". Nothing is left to release at this point, so the throw on a
            // listener that is already stopped is swallowed rather than surfacing from Dispose().
        }
    }

    public void Dispose() => Stop();

    /// <summary>
    /// Accepts one context at a time but never runs a handler on this loop: each context is dispatched and
    /// tracked before the next accept, so an open event stream cannot starve other requests.
    /// </summary>
    private async Task Loop()
    {
        while (listener.IsListening)
        {
            HttpListenerContext context;
            try
            {
                context = await listener.GetContextAsync().ConfigureAwait(false);
            }
            catch (Exception exception) when (exception is HttpListenerException or ObjectDisposedException or InvalidOperationException)
            {
                return;
            }

            var handler = Task.Run(() => HandleTrackedAsync(context));
            handlers[handler] = 0;
            _ = handler.ContinueWith(
                static (task, state) => ((ConcurrentDictionary<Task, byte>)state!).TryRemove(task, out _),
                handlers,
                CancellationToken.None,
                TaskContinuationOptions.ExecuteSynchronously,
                TaskScheduler.Default);
        }
    }

    /// <summary>No exception escapes a handler: a failed request still gets an answer, or is aborted.</summary>
    private async Task HandleTrackedAsync(HttpListenerContext context)
    {
        try
        {
            await HandleAsync(context).ConfigureAwait(false);
        }
        catch (Exception exception)
        {
            try
            {
                Write(context, 500, "application/json", Ops.Serialize(ErrorEnvelope.Of("internal", exception.Message)));
            }
            catch (Exception writeException) when (writeException is IOException or HttpListenerException or ObjectDisposedException or InvalidOperationException or SocketException)
            {
                // The response had already started (a stream) or the peer is gone: drop the connection.
                TryAbort(context.Response);
            }
        }
    }

    private async Task HandleAsync(HttpListenerContext context)
    {
        var request = context.Request;
        if (!IsLoopbackHost(request.Headers["Host"], Port))
        {
            Write(context, 421, "application/json", Ops.Serialize(ErrorEnvelope.Of("invalid_host", "host not allowed")));
            return;
        }

        if (request.HttpMethod != "GET")
        {
            Write(context, 405, "application/json", Ops.Serialize(ErrorEnvelope.Of("read_only", "GET only")));
            return;
        }

        var query = request.QueryString;
        string? Q(string name) => string.IsNullOrEmpty(query[name]) ? null : query[name];

        try
        {
            switch (request.Url?.AbsolutePath)
            {
                case "/":
                    Write(context, 200, "text/html; charset=utf-8", IndexHtml());
                    break;

                case "/api/revision":
                    Write(context, 200, "application/json", Ops.Serialize(new RevisionResponse(store.Revision())));
                    break;

                case "/api/events":
                    await StreamEventsAsync(context).ConfigureAwait(false);
                    break;

                case "/api/changes":
                    Write(context, 200, "application/json", ReadChangesPage(Q("since"), Q("limit"), Q("last"), Q("subject")));
                    break;

                case "/api/search":
                    Write(context, 200, "application/json", Ops.Search(store, new SearchRequest
                    {
                        Q = Q("q"),
                        Subject = Q("subject"),
                        Kind = Q("kind"),
                        Key = Q("key"),
                        Tag = Q("tag"),
                        Actor = Q("actor"),
                        Status = Q("status"),
                        Since = Q("since"),
                        RefTarget = Q("ref_target"),
                        Direction = Q("direction"),
                        Cursor = Q("cursor"),
                        Limit = Q("limit") is { } limit ? int.Parse(limit) : null,
                    }));
                    break;

                case "/api/compile":
                    if (Q("subject") is not { } subject)
                    {
                        Write(context, 400, "application/json", Ops.Serialize(ErrorEnvelope.Of("invalid_request", "subject is required")));
                        break;
                    }

                    Write(context, 200, Q("format") == "markdown" ? "text/markdown; charset=utf-8" : "application/json", Ops.Compile(store, new CompileRequest
                    {
                        Subject = subject,
                        Budget = Q("budget") is { } budget ? int.Parse(budget) : null,
                        Depth = Q("depth"),
                        Order = Q("order"),
                        Descendants = Q("descendants") is "true" or "1" ? true : null,
                        Needs = query.GetValues("need")?.ToList(),
                        Rank = Q("recency") is { } recency
                            ? new RankOptions { Recency = double.Parse(recency, System.Globalization.CultureInfo.InvariantCulture) }
                            : null,
                        Format = Q("format"),
                        BudgetMode = Q("budget_mode"),
                    }));
                    break;

                case "/api/graph":
                    Write(context, 200, "application/json", Ops.Graph(store, GraphRequest.FromQuery(Q("subject"), Q("depth"), Q("facts"), Q("max_nodes"))));
                    break;

                case "/api/subjects":
                    Write(context, 200, "application/json", Ops.Subjects(store));
                    break;

                case "/api/fact":
                    Write(context, 200, "application/json", Ops.GetFact(store, Q("id") ?? throw new DossierRequestException("invalid_request", "id is required")));
                    break;

                case "/app.js" or "/graph.js" or "/feed.js":
                    Write(context, 200, "text/javascript; charset=utf-8", Asset(request.Url!.AbsolutePath));
                    break;

                default:
                    Write(context, 404, "application/json", Ops.Serialize(ErrorEnvelope.Of("not_found", "not found")));
                    break;
            }
        }
        catch (DossierRequestException exception)
        {
            var status = exception.Code is "subject_not_found" or "fact_not_found" ? 404 : 400;
            Write(context, status, "application/json", Ops.Serialize(ErrorEnvelope.Of(exception.Code, exception.Message)));
        }
        catch (FormatException exception)
        {
            Write(context, 400, "application/json", Ops.Serialize(ErrorEnvelope.Of("invalid_request", exception.Message)));
        }
    }

    /// <summary>
    /// <c>GET /api/changes</c>: <c>?since=N&amp;limit=L</c> (limit defaults to 100, clamped to 1..500) or
    /// <c>?last=L</c> (the newest L rows), optionally narrowed to one <c>subject</c>. It builds the same
    /// <see cref="ChangesRequest"/> <see cref="Ops.Changes"/> serves over MCP and the CLI, so both
    /// transports agree on what is valid; anything unparseable is a 400 invalid_request.
    /// </summary>
    private string ReadChangesPage(string? since, string? limit, string? last, string? subject)
    {
        var style = System.Globalization.NumberStyles.Integer;
        var culture = System.Globalization.CultureInfo.InvariantCulture;

        int? count = null;
        if (limit is not null)
        {
            if (!int.TryParse(limit, style, culture, out var parsed))
            {
                throw new DossierRequestException("invalid_request", "limit must be an integer");
            }

            count = parsed;
        }

        int? newest = null;
        if (last is not null)
        {
            if (!int.TryParse(last, style, culture, out var parsed))
            {
                throw new DossierRequestException("invalid_request", "last must be an integer");
            }

            newest = parsed;
        }

        long? cursor = null;
        if (since is not null)
        {
            if (!long.TryParse(since, style, culture, out var parsed))
            {
                throw new DossierRequestException("invalid_request", "since must be a non-negative integer");
            }

            cursor = parsed;
        }

        return Ops.Changes(store, new ChangesRequest { Since = cursor, Last = newest, Limit = count, Subject = subject });
    }

    /// <summary>
    /// Server-Sent Events: a baseline <c>revision</c> event, then the journal pages behind it as
    /// <c>changes</c> events (each carrying its own <c>id</c> so a reconnect resumes), a <c>reset</c>
    /// when the resume point fell out of retention, and a comment keepalive while idle. The stream never
    /// blocks the accept loop and ends quietly on any write failure.
    /// </summary>
    private async Task StreamEventsAsync(HttpListenerContext context)
    {
        if (Interlocked.Increment(ref openStreams) > MaxEventStreams)
        {
            // The refused request never held a slot, so the counter stays balanced.
            Interlocked.Decrement(ref openStreams);
            Write(context, 503, "application/json", Ops.Serialize(ErrorEnvelope.Of("busy", $"at most {MaxEventStreams} live event streams")));
            return;
        }

        try
        {
            var response = context.Response;
            response.StatusCode = 200;
            response.ContentType = "text/event-stream; charset=utf-8";
            response.SendChunked = true;
            response.KeepAlive = true;
            response.AddHeader("Cache-Control", "no-store");
            response.AddHeader("Content-Security-Policy", ContentSecurityPolicy);
            response.AddHeader("X-Content-Type-Options", "nosniff");

            var token = shutdown.Token;
            var output = response.OutputStream;

            // Latest value and its signal are read together, so a change between the read and the await
            // completes the task already in hand instead of being lost.
            long sent;
            Task changed;
            lock (revisionLock)
            {
                sent = revision;
                changed = revisionChanged.Task;
            }

            // Two watermarks: `sent` is what the revision frame last said, `journal` is how far the
            // journal has been delivered. They only meet by accident: the journal is the resume point.
            var journal = ReadResumePoint(context.Request, sent);

            // A journal read that failed leaves rows undelivered with no revision change to announce
            // them, so the stream retries on every wake and on every keepalive until it succeeds.
            var journalBehind = false;

            await output.WriteAsync(RetryFrame, token).ConfigureAwait(false);
            await output.FlushAsync(token).ConfigureAwait(false);
            await WriteRevisionAsync(output, sent, token).ConfigureAwait(false);
            (journal, journalBehind) = await DrainChangesAsync(output, sent, journal, token).ConfigureAwait(false);

            while (!token.IsCancellationRequested)
            {
                try
                {
                    await changed.WaitAsync(KeepaliveInterval, token).ConfigureAwait(false);
                }
                catch (TimeoutException)
                {
                    await output.WriteAsync(KeepaliveFrame, token).ConfigureAwait(false);
                    await output.FlushAsync(token).ConfigureAwait(false);
                    if (journalBehind)
                    {
                        (journal, journalBehind) = await DrainChangesAsync(output, sent, journal, token).ConfigureAwait(false);
                    }

                    continue;
                }

                long current;
                lock (revisionLock)
                {
                    current = revision;
                    changed = revisionChanged.Task;
                }

                // A replaced store restarts the counter, so inequality is the test, not growth.
                var advanced = current != sent;
                if (advanced)
                {
                    sent = current;
                    await WriteRevisionAsync(output, sent, token).ConfigureAwait(false);
                }

                if (advanced || journalBehind)
                {
                    (journal, journalBehind) = await DrainChangesAsync(output, sent, journal, token).ConfigureAwait(false);
                }
            }
        }
        catch (OperationCanceledException)
        {
            TryAbort(context.Response);
        }
        catch (Exception exception) when (exception is IOException or HttpListenerException or ObjectDisposedException or InvalidOperationException or SocketException)
        {
            TryAbort(context.Response);
        }
        finally
        {
            Interlocked.Decrement(ref openStreams);
        }
    }

    /// <summary>
    /// The journal cursor a stream starts from: <c>Last-Event-ID</c> wins over <c>?since=</c>, and neither
    /// means the revision the server last polled, which can be up to one poll interval old, so a fresh
    /// stream may replay rows written in that window.
    /// </summary>
    private static long ReadResumePoint(HttpListenerRequest request, long current)
    {
        var style = NumberStyles.Integer;
        var culture = CultureInfo.InvariantCulture;
        var header = request.Headers["Last-Event-ID"];
        if (long.TryParse(header, style, culture, out var resumed) && resumed >= 0)
        {
            return resumed;
        }

        var since = request.QueryString["since"];
        return long.TryParse(since, style, culture, out var fromQuery) && fromQuery >= 0 ? fromQuery : current;
    }

    /// <summary>
    /// Delivers the journal behind <paramref name="journal"/> as <c>changes</c> frames of at most
    /// <see cref="ChangePageSize"/> rows, up to <see cref="ChangeDrainCap"/> rows per tick. More still
    /// pending, or a resume point outside the retained window, becomes one <c>reset</c> and the cursor
    /// jumps to the revision the frame names. A failing read skips the tick; it never ends the stream, and
    /// the caller retries it without waiting for a new write.
    /// </summary>
    /// <returns>The new journal cursor, and whether a read failed so rows are still undelivered.</returns>
    private async Task<(long Journal, bool Behind)> DrainChangesAsync(Stream output, long revision, long journal, CancellationToken token)
    {
        var drained = 0;
        while (drained < ChangeDrainCap)
        {
            ChangesPage page;
            try
            {
                page = ChangesReader is { } reader ? reader(journal, ChangePageSize) : store.ReadChanges(journal, ChangePageSize);
            }
            catch (Exception)
            {
                // A locked or missing database is a skipped tick, not a dead stream: the caller retries.
                return (journal, true);
            }

            if (page.Reset)
            {
                await WriteResetAsync(output, revision, token).ConfigureAwait(false);
                return (revision, false);
            }

            if (page.Changes.Count == 0)
            {
                return (journal, false);
            }

            await WriteChangesAsync(output, page, token).ConfigureAwait(false);
            journal = page.Next;
            drained += page.Changes.Count;

            if (!page.Truncated)
            {
                return (journal, false);
            }

            if (drained >= ChangeDrainCap)
            {
                await WriteResetAsync(output, revision, token).ConfigureAwait(false);
                return (revision, false);
            }
        }

        return (journal, false);
    }

    private static async Task WriteRevisionAsync(Stream output, long value, CancellationToken token)
    {
        var frame = Encoding.UTF8.GetBytes($"event: revision\ndata: {value.ToString(CultureInfo.InvariantCulture)}\n\n");
        await output.WriteAsync(frame, token).ConfigureAwait(false);
        await output.FlushAsync(token).ConfigureAwait(false);
    }

    /// <summary>One journal page. The <c>id</c> is the cursor to resume from, so a reconnect never repeats it.</summary>
    private static async Task WriteChangesAsync(Stream output, ChangesPage page, CancellationToken token)
    {
        var cursor = page.Next.ToString(CultureInfo.InvariantCulture);
        var frame = Encoding.UTF8.GetBytes($"id: {cursor}\nevent: changes\ndata: {Ops.Serialize(page)}\n\n");
        await output.WriteAsync(frame, token).ConfigureAwait(false);
        await output.FlushAsync(token).ConfigureAwait(false);
    }

    /// <summary>Refetch everything: the resume point is meaningless, so the frame id and payload are the revision.</summary>
    private static async Task WriteResetAsync(Stream output, long revision, CancellationToken token)
    {
        var value = revision.ToString(CultureInfo.InvariantCulture);
        var frame = Encoding.UTF8.GetBytes($"id: {value}\nevent: reset\ndata: {value}\n\n");
        await output.WriteAsync(frame, token).ConfigureAwait(false);
        await output.FlushAsync(token).ConfigureAwait(false);
    }

    private static void TryAbort(HttpListenerResponse response)
    {
        try
        {
            response.Abort();
        }
        catch (Exception exception) when (exception is ObjectDisposedException or InvalidOperationException or HttpListenerException)
        {
        }
    }

    private static TaskCompletionSource NewSignal() => new(TaskCreationOptions.RunContinuationsAsynchronously);

    /// <summary>
    /// Polls the durable revision counter and wakes every open stream on a change. A locked or missing
    /// database is not fatal: the next tick retries. Any other failure is not fatal either, or one bad
    /// read would silently end live updates for the whole session.
    /// </summary>
    private async Task PollRevisionAsync()
    {
        var token = shutdown.Token;
        while (!token.IsCancellationRequested)
        {
            try
            {
                await Task.Delay(revisionPollInterval, token).ConfigureAwait(false);
            }
            catch (OperationCanceledException)
            {
                return;
            }

            long value;
            try
            {
                value = RevisionReader is { } reader ? reader() : store.Revision();
            }
            catch (ObjectDisposedException)
            {
                return;
            }
            catch (Exception)
            {
                continue;
            }

            TaskCompletionSource? signal = null;
            lock (revisionLock)
            {
                if (value != revision)
                {
                    revision = value;
                    signal = revisionChanged;
                    revisionChanged = NewSignal();
                }
            }

            signal?.TrySetResult();
        }
    }

    private long ReadRevision()
    {
        try
        {
            return store.Revision();
        }
        catch (Exception exception) when (exception is SqliteException or ObjectDisposedException)
        {
            return 0;
        }
    }

    private static string IndexHtml() => Asset("/");

    /// <summary>
    /// The fixed set of embedded files this server may serve: request path to logical resource name.
    /// Nothing from the request ever reaches GetManifestResourceStream except through this map.
    /// </summary>
    private static readonly Dictionary<string, string> Assets = new(StringComparer.Ordinal)
    {
        ["/"] = "index.html",
        ["/app.js"] = "app.js",
        ["/graph.js"] = "graph.js",
        ["/feed.js"] = "feed.js",
    };

    private static readonly System.Collections.Concurrent.ConcurrentDictionary<string, string> AssetCache = new(StringComparer.Ordinal);

    private static string Asset(string path) => AssetCache.GetOrAdd(path, static key =>
    {
        var name = Assets[key];
        using var stream = typeof(WebServer).Assembly.GetManifestResourceStream(name)
            ?? throw new InvalidOperationException($"{name} resource missing");
        using var reader = new StreamReader(stream, Encoding.UTF8);
        return reader.ReadToEnd();
    });

    private const string ContentSecurityPolicy =
        "default-src 'none'; script-src 'self'; style-src 'unsafe-inline'; connect-src 'self'; img-src 'self' data:; base-uri 'none'; form-action 'none'; frame-ancestors 'none'";

    private static void Write(HttpListenerContext context, int status, string contentType, string body)
    {
        var bytes = Encoding.UTF8.GetBytes(body);
        context.Response.StatusCode = status;
        context.Response.ContentType = contentType;
        context.Response.ContentLength64 = bytes.Length;
        context.Response.AddHeader("Content-Security-Policy", ContentSecurityPolicy);
        context.Response.AddHeader("X-Content-Type-Options", "nosniff");
        context.Response.OutputStream.Write(bytes, 0, bytes.Length);
        context.Response.Close();
    }
}
