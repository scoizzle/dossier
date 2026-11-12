using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

public sealed class WebTests
{
    [Test]
    public async Task Web_FactSubjectsAndErrors()
    {
        using var db = new TempDb();
        var factId = db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("alpha web fact"))).Response.Facts[0].Id;

        using var server = await StartServerAsync(db.Store);
        try
        {
            using var http = new HttpClient { BaseAddress = new Uri($"http://127.0.0.1:{server.Port}/") };

            var fact = await http.GetAsync("api/fact?id=" + Uri.EscapeDataString(factId));
            await Assert.That((int)fact.StatusCode).IsEqualTo(200);
            await Assert.That(await fact.Content.ReadAsStringAsync()).IsEqualTo(JsonSerializer.Serialize(db.Store.Show(factId), JsonCodec.Options));

            var subjects = JsonDocument.Parse(await http.GetStringAsync("api/subjects")).RootElement;
            await Assert.That(subjects[0].GetProperty("name").GetString()).IsEqualTo("Widget");

            await Assert.That((int)(await http.GetAsync("api/fact?id=missing")).StatusCode).IsEqualTo(404);
            await Assert.That((int)(await http.GetAsync("api/compile")).StatusCode).IsEqualTo(400);
            await Assert.That((int)(await http.GetAsync("api/compile?subject=Nobody")).StatusCode).IsEqualTo(404);
            await Assert.That((int)(await http.PostAsync("api/search", new StringContent(""))).StatusCode).IsEqualTo(405);
        }
        finally
        {
            server.Stop();
        }
    }

    [Test]
    public async Task Web_ServesSearchJsonAndIndex()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("alpha web fact")));

        using var server = await StartServerAsync(db.Store);
        await Assert.That(server.Port).IsGreaterThan(0);
        try
        {
            using var http = new HttpClient { BaseAddress = new Uri($"http://127.0.0.1:{server.Port}/") };

            var search = await http.GetAsync("api/search?q=alpha");
            await Assert.That((int)search.StatusCode).IsEqualTo(200);
            await Assert.That(search.Content.Headers.ContentType!.MediaType).IsEqualTo("application/json");
            var json = JsonDocument.Parse(await search.Content.ReadAsStringAsync()).RootElement;
            await Assert.That(json.GetProperty("total").GetInt32()).IsEqualTo(1);

            var compile = await http.GetAsync("api/compile?subject=Widget");
            await Assert.That((int)compile.StatusCode).IsEqualTo(200);
            var dossier = JsonDocument.Parse(await compile.Content.ReadAsStringAsync()).RootElement;
            await Assert.That(dossier.GetProperty("subject").GetProperty("name").GetString()).IsEqualTo("Widget");

            var index = await http.GetAsync("");
            await Assert.That((int)index.StatusCode).IsEqualTo(200);
            await Assert.That(index.Content.Headers.ContentType!.MediaType).IsEqualTo("text/html");
            await Assert.That((await index.Content.ReadAsStringAsync()).Contains("<html")).IsTrue();
        }
        finally
        {
            server.Stop();
        }
    }

    private const string ExpectedCsp =
        "default-src 'none'; script-src 'self'; style-src 'unsafe-inline'; connect-src 'self'; img-src 'self' data:; base-uri 'none'; form-action 'none'; frame-ancestors 'none'";

    [Test]
    public async Task Web_Graph_ApiAndErrors()
    {
        using var db = new TempDb();
        GraphSeed.Populate(db.Store);

        using var server = await StartServerAsync(db.Store);
        try
        {
            using var http = new HttpClient { BaseAddress = new Uri($"http://127.0.0.1:{server.Port}/") };

            var ok = await http.GetAsync("api/graph?subject=s-root");
            await Assert.That((int)ok.StatusCode).IsEqualTo(200);
            await Assert.That(ok.Content.Headers.ContentType!.MediaType).IsEqualTo("application/json");
            var body = await ok.Content.ReadAsStringAsync();
            await Assert.That(body).IsEqualTo(Ops.Graph(db.Store, new GraphRequest { Subject = "s-root" }));

            var full = await http.GetStringAsync("api/graph?subject=Acme&depth=2&facts=1&max_nodes=500");
            await Assert.That(full).IsEqualTo(Ops.Graph(db.Store, new GraphRequest { Subject = "Acme", Depth = 2, Facts = true, MaxNodes = 500 }));

            var tree = JsonDocument.Parse(await http.GetStringAsync("api/graph?facts=true&max_nodes=3")).RootElement;
            await Assert.That(tree.GetProperty("subjects").GetArrayLength()).IsEqualTo(3);
            await Assert.That(tree.GetProperty("facts").GetArrayLength()).IsEqualTo(0);

            async Task Expect(string query, int status, string code)
            {
                var response = await http.GetAsync("api/graph" + query);
                await Assert.That((int)response.StatusCode).IsEqualTo(status);
                var error = JsonDocument.Parse(await response.Content.ReadAsStringAsync()).RootElement.GetProperty("error");
                await Assert.That(error.GetProperty("code").GetString()).IsEqualTo(code);
            }

            await Expect("?subject=s-root&depth=4", 400, "bad_depth");
            await Expect("?subject=s-root&depth=abc", 400, "bad_depth");
            await Expect("?subject=s-root&depth=-1", 400, "bad_depth");
            await Expect("?subject=s-root&max_nodes=0", 400, "bad_max_nodes");
            await Expect("?subject=s-root&max_nodes=2001", 400, "bad_max_nodes");
            await Expect("?subject=s-root&facts=maybe", 400, "bad_facts");
            await Expect("?subject=nobody", 404, "subject_not_found");
            await Assert.That((int)(await http.PostAsync("api/graph?subject=s-root", new StringContent(""))).StatusCode).IsEqualTo(405);
        }
        finally
        {
            server.Stop();
        }
    }

    [Test]
    public async Task Web_Assets_ContentTypesNosniffAndCsp()
    {
        using var db = new TempDb();
        GraphSeed.Populate(db.Store);

        using var server = await StartServerAsync(db.Store);
        try
        {
            using var http = new HttpClient { BaseAddress = new Uri($"http://127.0.0.1:{server.Port}/") };

            foreach (var path in new[] { "", "app.js", "graph.js", "api/graph?subject=s-root", "api/graph?depth=9", "api/graph?subject=nobody", "nothing-here" })
            {
                var response = await http.GetAsync(path);
                var csp = response.Headers.GetValues("Content-Security-Policy").Single();
                await Assert.That(csp).IsEqualTo(ExpectedCsp);
                await Assert.That(response.Headers.GetValues("X-Content-Type-Options").Single()).IsEqualTo("nosniff");
            }

            foreach (var path in new[] { "app.js", "graph.js" })
            {
                var response = await http.GetAsync(path);
                await Assert.That((int)response.StatusCode).IsEqualTo(200);
                await Assert.That(response.Content.Headers.ContentType!.ToString()).IsEqualTo("text/javascript; charset=utf-8");
                await Assert.That((await response.Content.ReadAsStringAsync()).Length).IsGreaterThan(100);
            }

            var graphJs = await http.GetStringAsync("graph.js");
            await Assert.That(graphJs.Contains("DossierGraph")).IsTrue();

            var index = await http.GetAsync("");
            var html = await index.Content.ReadAsStringAsync();
            await Assert.That(html.Contains("src=\"/app.js\"")).IsTrue();
            await Assert.That(html.Contains("src=\"/graph.js\"")).IsTrue();
            // No inline script survives: every <script> carries a src.
            await Assert.That(System.Text.RegularExpressions.Regex.IsMatch(html, "<script(?![^>]*\\ssrc=)")).IsFalse();

            // Only the fixed whitelist is served: nothing derived from the request path reaches the resources.
            foreach (var path in new[] { "index.html", "app.js/", "APP.JS", "graph.js.map", "www/app.js", "Dossier.dll" })
            {
                await Assert.That((int)(await http.GetAsync(path)).StatusCode).IsEqualTo(404);
            }

            await Assert.That((int)(await http.PostAsync("app.js", new StringContent(""))).StatusCode).IsEqualTo(405);
        }
        finally
        {
            server.Stop();
        }
    }

    [Test]
    public async Task Web_ServesLocalhostByName()
    {
        using var db = new TempDb();
        using var server = await StartServerAsync(db.Store);
        try
        {
            using var http = new HttpClient();
            var response = await http.GetAsync($"http://localhost:{server.Port}/");
            await Assert.That((int)response.StatusCode).IsEqualTo(200);
            await Assert.That((await response.Content.ReadAsStringAsync()).Contains("<html")).IsTrue();
        }
        finally
        {
            server.Stop();
        }
    }

    [Test]
    public async Task Web_ForeignHostIsNeverServed()
    {
        using var db = new TempDb();
        using var server = await StartServerAsync(db.Store);
        try
        {
            using var http = new HttpClient();
            using var request = new HttpRequestMessage(HttpMethod.Get, $"http://127.0.0.1:{server.Port}/");
            request.Headers.Host = $"evil.test:{server.Port}";
            var response = await http.SendAsync(request);
            await Assert.That((int)response.StatusCode).IsNotEqualTo(200);
            await Assert.That((await response.Content.ReadAsStringAsync()).Contains("<html")).IsFalse();
        }
        finally
        {
            server.Stop();
        }
    }

    [Test]
    public async Task HostGuard_AllowsOnlyLoopbackNamesAndTheServePort()
    {
        (string? Host, bool Ok)[] cases =
        [
            ("localhost:8787", true), ("LOCALHOST:8787", true), ("localhost", true), ("127.0.0.1:8787", true),
            ("[::1]:8787", true), (null, true), ("", true),
            ("127.0.0.1:9999", false), ("evil.test:8787", false), ("127.0.0.1.evil.test:8787", false), ("localhost.evil.test:8787", false),

            // Edge cases, pinning current behaviour. A trailing dot is not the name "localhost"
            // and the guard compares names ordinally, so both reject: false.
            ("localhost.", false), ("127.0.0.1.", false),
            // An empty port is not the serve port: false.
            ("localhost:", false),
            // Whitespace is neither trimmed from the name nor accepted around the port: false, false.
            (" localhost:8787", false), ("localhost:8787 ", false),
            // Userinfo leaves the name "user@localhost", which is not a loopback name: false.
            ("user@localhost:8787", false),
            // A loopback name with no port is accepted: true.
            ("127.0.0.1", true),
            // The bracketed form with no port is accepted: true.
            ("[::1]", true),
            // An unterminated bracket is never a loopback form: false.
            ("[::1", false),
            // Only the compressed spelling is recognised; the expanded address is not: false.
            ("[0:0:0:0:0:0:0:1]:8787", false),
        ];
        foreach (var (host, ok) in cases)
        {
            await Assert.That(WebServer.IsLoopbackHost(host, 8787)).IsEqualTo(ok).Because($"host '{host}' guard result");
        }
    }

    [Test]
    public async Task ShouldAddLocalhostPrefix_OnlyWhenEveryAddressIsLoopbackAndTheFirstBinds()
    {
        static Func<IPAddress, bool> Binds(params IPAddress[] bindable) => address => bindable.Contains(address);

        IPAddress v4 = IPAddress.Loopback;
        IPAddress v6 = IPAddress.IPv6Loopback;
        IPAddress external = IPAddress.Parse("192.0.2.10");
        IPAddress linkLocal = IPAddress.Parse("fe80::1");

        (string Name, IPAddress[] Addresses, Func<IPAddress, bool> CanBind, bool Expected)[] cases =
        [
            // Every resolved address is loopback and the first is bindable: serve the name.
            ("v4 loopback only", [v4], Binds(v4), true),
            ("both loopbacks", [v6, v4], Binds(v6, v4), true),
            // Only the first address is registered, so a later one that cannot be bound (a leftover
            // ::1 on a host with IPv6 disabled) must not stop the localhost prefix: true.
            ("first binds, later does not", [v4, v6], Binds(v4), true),
            // Any non-loopback resolution makes the name unsafe: false.
            ("non-loopback first", [external, v4], Binds(external, v4), false),
            ("non-loopback last", [v4, external], Binds(v4, external), false),
            ("link-local v6", [v6, linkLocal], Binds(v6, linkLocal), false),
            // DNS failed and resolved nothing: false.
            ("empty", [], Binds(), false),
            // The first address cannot be bound, so registering its prefix would throw on Start: false.
            ("first does not bind", [v6], Binds(), false),
        ];

        foreach (var (name, addresses, canBind, expected) in cases)
        {
            await Assert.That(WebServer.ShouldAddLocalhostPrefix(addresses, canBind)).IsEqualTo(expected).Because(name);
        }
    }

    [Test]
    public async Task CanBind_ReturnsFalseWhenSocketCreationThrows()
    {
        static Socket Throws(IPAddress _) => throw new SocketException((int)SocketError.AddressFamilyNotSupported);

        // On a host where localhost resolves to ::1 but IPv6 sockets cannot be created, the Socket
        // constructor throws. The probe must answer false instead of letting that escape
        // ShouldAddLocalhostPrefix and the WebServer constructor.
        await Assert.That(WebServer.CanBind(IPAddress.IPv6Loopback, Throws)).IsFalse();
    }

    [Test]
    public async Task CanBind_ReturnsFalseWhenFactoryThrowsPlatformNotSupported()
    {
        static Socket Throws(IPAddress _) => throw new PlatformNotSupportedException("IPv6 is not enabled");

        await Assert.That(WebServer.CanBind(IPAddress.IPv6Loopback, Throws)).IsFalse();
    }

    [Test]
    public async Task CanBind_ReturnsFalseWhenFactoryThrowsNotSupported()
    {
        static Socket Throws(IPAddress _) => throw new NotSupportedException("address family unavailable");

        await Assert.That(WebServer.CanBind(IPAddress.IPv6Loopback, Throws)).IsFalse();
    }

    [Test]
    public async Task CanBind_ReturnsTrueForBindableLoopback()
    {
        await Assert.That(WebServer.CanBind(IPAddress.Loopback, static address => new Socket(address.AddressFamily, SocketType.Stream, ProtocolType.Tcp))).IsTrue();
    }

    [Test]
    public async Task Web_PortInUseStillThrows()
    {
        using var db = new TempDb();
        using var first = await StartServerAsync(db.Store);
        try
        {
            using var second = new WebServer(db.Store, first.Port);
            Exception? caught = null;
            try
            {
                second.Start();
            }
            catch (Exception exception)
            {
                caught = exception;
            }

            await Assert.That(caught is HttpListenerException or SocketException).IsTrue();
        }
        finally
        {
            first.Stop();
        }
    }

    /// <summary>
    /// Starts a web server on a fresh random port. The previous pattern reserved an ephemeral
    /// port with a TcpListener, released it, then bound the same number, so another process could
    /// claim the port in the gap. Here the port is bound directly and a failed bind is retried on
    /// a new port, bounded and without sleeps. The range avoids the OS ephemeral range used by
    /// outgoing test connections.
    /// </summary>
    private static Task<WebServer> StartServerAsync(DossierStore store)
    {
        const int FirstPort = 20_000;
        const int LastPortExclusive = 32_000;
        const int Attempts = 50;

        for (var attempt = 0; attempt < Attempts; attempt++)
        {
            var server = new WebServer(store, Random.Shared.Next(FirstPort, LastPortExclusive));
            try
            {
                server.Start();
            }
            catch (Exception exception) when (exception is HttpListenerException or SocketException)
            {
                server.Dispose();
                continue;
            }

            return Task.FromResult(server);
        }

        throw new InvalidOperationException($"could not bind a loopback port after {Attempts} attempts");
    }
}
