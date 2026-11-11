using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;

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
    private readonly DossierStore store;
    private readonly HttpListener listener = new();
    private Task? loop;

    public WebServer(DossierStore store, int port)
    {
        this.store = store;
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
    private static bool CanBind(IPAddress address)
    {
        var socket = new Socket(address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        try
        {
            socket.Bind(new IPEndPoint(address, 0));
            return true;
        }
        catch (SocketException)
        {
            return false;
        }
        finally
        {
            socket.Dispose();
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

    public void Start()
    {
        listener.Start();
        loop = Task.Run(Loop);
    }

    public void Stop()
    {
        if (listener.IsListening)
        {
            listener.Stop();
        }

        try
        {
            loop?.Wait(TimeSpan.FromSeconds(5));
        }
        catch (AggregateException)
        {
        }

        listener.Close();
    }

    public void Dispose() => Stop();

    private async Task Loop()
    {
        while (listener.IsListening)
        {
            HttpListenerContext context;
            try
            {
                context = await listener.GetContextAsync();
            }
            catch (Exception exception) when (exception is HttpListenerException or ObjectDisposedException or InvalidOperationException)
            {
                return;
            }

            try
            {
                Handle(context);
            }
            catch (Exception exception)
            {
                Write(context, 500, "application/json", Ops.Serialize(ErrorEnvelope.Of("internal", exception.Message)));
            }
        }
    }

    private void Handle(HttpListenerContext context)
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

                case "/app.js" or "/graph.js":
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
