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
