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

        var listener = new TcpListener(IPAddress.Loopback, 0);
        listener.Start();
        var port = ((IPEndPoint)listener.LocalEndpoint).Port;
        listener.Stop();

        using var server = new WebServer(db.Store, port);
        server.Start();
        try
        {
            using var http = new HttpClient { BaseAddress = new Uri($"http://127.0.0.1:{port}/") };

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

        var listener = new TcpListener(IPAddress.Loopback, 0);
        listener.Start();
        var port = ((IPEndPoint)listener.LocalEndpoint).Port;
        listener.Stop();

        using var server = new WebServer(db.Store, port);
        server.Start();
        try
        {
            using var http = new HttpClient { BaseAddress = new Uri($"http://127.0.0.1:{port}/") };

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
}
