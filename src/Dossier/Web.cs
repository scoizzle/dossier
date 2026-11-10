using System.Net;
using System.Reflection;
using System.Text;

namespace Dossier;

/// <summary>
/// Minimal read-only web UI and JSON API, bound to 127.0.0.1 only. Every endpoint calls the
/// same core entry points as the CLI and MCP transports.
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
