using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.Json;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

/// <summary>
/// The live channel: /api/revision reports the durable store revision and /api/events pushes it as
/// Server-Sent Events, so the graph view can refresh when another process writes.
/// </summary>
public sealed class WebEventsTests
{
    private static readonly TimeSpan PollInterval = TimeSpan.FromMilliseconds(20);

    /// <summary>The contract the client was built against: eight concurrent streams, then 503 busy.</summary>
    private const int MaxEventStreams = 8;

    private const string ExpectedCsp =
        "default-src 'none'; script-src 'self'; style-src 'unsafe-inline'; connect-src 'self'; img-src 'self' data:; base-uri 'none'; form-action 'none'; frame-ancestors 'none'";

    private static HttpClient Client(WebServer server) =>
        new() { BaseAddress = new Uri($"http://127.0.0.1:{server.Port}/") };

    [Test]
    public async Task Web_RevisionEndpointReportsStoreRevision()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("alpha")));
        using var server = await TestServers.StartAsync(db.Store, PollInterval);
        var second = new DossierStore(db.DbPath);
        try
        {
            using var http = Client(server);

            var response = await http.GetAsync("api/revision");
            await Assert.That((int)response.StatusCode).IsEqualTo(200);
            await Assert.That(response.Content.Headers.ContentType!.MediaType).IsEqualTo("application/json");
            var first = JsonDocument.Parse(await response.Content.ReadAsStringAsync()).RootElement.GetProperty("revision").GetInt64();
            await Assert.That(first).IsEqualTo(db.Store.Revision());

            second.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("beta")));
            var body = JsonDocument.Parse(await http.GetStringAsync("api/revision")).RootElement;
            var later = body.GetProperty("revision").GetInt64();
            await Assert.That(later).IsGreaterThan(first);
            await Assert.That(later).IsEqualTo(db.Store.Revision());

            await Assert.That((int)(await http.PostAsync("api/revision", new StringContent(""))).StatusCode).IsEqualTo(405);
        }
        finally
        {
            server.Stop();
            TempDb.ClearPool(second);
        }
    }

    [Test]
    public async Task Web_Events_SendsBaselineEventImmediately()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("alpha")));
        using var server = await TestServers.StartAsync(db.Store, PollInterval);
        try
        {
            using var http = Client(server);
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));

            using var response = await http.GetAsync("api/events", HttpCompletionOption.ResponseHeadersRead, cts.Token);
            await Assert.That((int)response.StatusCode).IsEqualTo(200);
            await Assert.That(response.Content.Headers.ContentType!.MediaType).IsEqualTo("text/event-stream");
            await Assert.That(response.Content.Headers.ContentType!.CharSet).IsEqualTo("utf-8");
            await Assert.That(response.Headers.CacheControl!.NoStore).IsTrue();
            await Assert.That(response.Headers.GetValues("Content-Security-Policy").Single()).IsEqualTo(ExpectedCsp);
            await Assert.That(response.Headers.GetValues("X-Content-Type-Options").Single()).IsEqualTo("nosniff");

            using var stream = await response.Content.ReadAsStreamAsync(cts.Token);
            using var reader = new StreamReader(stream, Encoding.UTF8);
            var (preamble, events) = await ReadEventsAsync(reader, 1, cts.Token);
            await Assert.That(preamble.Contains("retry: 1000")).IsTrue();
            await Assert.That(events[0].Name).IsEqualTo("revision");
            await Assert.That(ParseRevision(events[0])).IsEqualTo(db.Store.Revision());
        }
        finally
        {
            server.Stop();
        }
    }

    [Test]
    public async Task Web_Events_EmitsAfterWriteFromSecondStore()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("alpha")));
        var second = new DossierStore(db.DbPath);
        try
        {
            using var server = await TestServers.StartAsync(db.Store, PollInterval);
            try
            {
                using var http = Client(server);
                using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));

                using var response = await http.GetAsync("api/events", HttpCompletionOption.ResponseHeadersRead, cts.Token);
                await Assert.That((int)response.StatusCode).IsEqualTo(200);
                using var stream = await response.Content.ReadAsStreamAsync(cts.Token);
                using var reader = new StreamReader(stream, Encoding.UTF8);

                var (_, baseline) = await ReadEventsAsync(reader, 1, cts.Token);
                var start = ParseRevision(baseline[0]);
                await Assert.That(start).IsEqualTo(db.Store.Revision());

                second.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("beta")));

                var (_, later) = await ReadEventsAsync(reader, 1, cts.Token);
                var next = ParseRevision(later[0]);
                await Assert.That(next).IsGreaterThan(start);
                await Assert.That(next).IsEqualTo(db.Store.Revision());
            }
            finally
            {
                server.Stop();
            }
        }
        finally
        {
            TempDb.ClearPool(second);
        }
    }

    [Test]
    public async Task Web_Events_StreamDoesNotBlockOtherEndpoints()
    {
        using var db = new TempDb();
        GraphSeed.Populate(db.Store);
        using var server = await TestServers.StartAsync(db.Store, PollInterval);
        try
        {
            using var http = Client(server);
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));

            using var events = await http.GetAsync("api/events", HttpCompletionOption.ResponseHeadersRead, cts.Token);
            await Assert.That((int)events.StatusCode).IsEqualTo(200);
            await Assert.That(events.Content.Headers.ContentType!.MediaType).IsEqualTo("text/event-stream");

            // The open stream holds one connection, not the accept loop: other endpoints answer at once.
            var subjects = await http.GetAsync("api/subjects", cts.Token);
            await Assert.That((int)subjects.StatusCode).IsEqualTo(200);

            var graph = await http.GetAsync("api/graph?subject=s-root", cts.Token);
            await Assert.That((int)graph.StatusCode).IsEqualTo(200);
            await Assert.That(graph.Content.Headers.ContentType!.MediaType).IsEqualTo("application/json");
        }
        finally
        {
            server.Stop();
        }
    }

    [Test]
    public async Task Web_Dispose_EndsOpenStreams()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("alpha")));
        var server = await TestServers.StartAsync(db.Store, PollInterval);
        using var http = Client(server);
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));

        using var response = await http.GetAsync("api/events", HttpCompletionOption.ResponseHeadersRead, cts.Token);
        await Assert.That((int)response.StatusCode).IsEqualTo(200);
        using var stream = await response.Content.ReadAsStreamAsync(cts.Token);
        using var reader = new StreamReader(stream, Encoding.UTF8);

        // The baseline proves the stream is live before Dispose runs.
        var (_, events) = await ReadEventsAsync(reader, 1, cts.Token);
        await Assert.That(events.Count).IsEqualTo(1);

        var stopwatch = Stopwatch.StartNew();
        var dispose = Task.Run(server.Dispose);
        var disposed = await Task.WhenAny(dispose, Task.Delay(TimeSpan.FromSeconds(3), cts.Token));
        await Assert.That(ReferenceEquals(disposed, dispose)).IsTrue();
        await dispose;
        stopwatch.Stop();
        await Assert.That(stopwatch.Elapsed).IsLessThan(TimeSpan.FromSeconds(3));

        // The reading side sees end-of-stream or a clean disconnect, not a hang.
        var drain = Task.Run(async () =>
        {
            try
            {
                await reader.ReadToEndAsync(cts.Token);
                return true;
            }
            catch (Exception exception) when (exception is IOException or HttpRequestException or OperationCanceledException or ObjectDisposedException)
            {
                return true;
            }
        });
        var finished = await Task.WhenAny(drain, Task.Delay(TimeSpan.FromSeconds(2), cts.Token));
        await Assert.That(ReferenceEquals(finished, drain)).IsTrue();
        await Assert.That(await drain).IsTrue();
    }

    [Test]
    public async Task Web_Events_RejectsStreamsBeyondTheCap()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("alpha")));
        using var server = await TestServers.StartAsync(db.Store, PollInterval);
        var open = new List<HttpResponseMessage>();
        try
        {
            using var http = Client(server);
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

            for (var i = 0; i < MaxEventStreams; i++)
            {
                var stream = await http.GetAsync("api/events", HttpCompletionOption.ResponseHeadersRead, cts.Token);
                await Assert.That((int)stream.StatusCode).IsEqualTo(200);
                await Assert.That(stream.Content.Headers.ContentType!.MediaType).IsEqualTo("text/event-stream");
                open.Add(stream);
            }

            var busy = await http.GetAsync("api/events", HttpCompletionOption.ResponseHeadersRead, cts.Token);
            await Assert.That((int)busy.StatusCode).IsEqualTo(503);
            var error = JsonDocument.Parse(await busy.Content.ReadAsStringAsync(cts.Token)).RootElement.GetProperty("error");
            await Assert.That(error.GetProperty("code").GetString()).IsEqualTo("busy");
            busy.Dispose();

            // Closing one stream frees its slot; the server learns of the hang-up on a failed write, so keep
            // the revision moving: each change makes every stream write, and the closed one errors out.
            open[^1].Dispose();
            open.RemoveAt(open.Count - 1);

            HttpResponseMessage? reopened = null;
            var deadline = Stopwatch.StartNew();
            var nudges = 0;
            while (reopened is null && deadline.Elapsed < TimeSpan.FromSeconds(15))
            {
                var attempt = await http.GetAsync("api/events", HttpCompletionOption.ResponseHeadersRead, cts.Token);
                if ((int)attempt.StatusCode == 200)
                {
                    reopened = attempt;
                    break;
                }

                attempt.Dispose();
                if (nudges < 50)
                {
                    nudges++;
                    db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("nudge " + nudges)));
                }

                await Task.Delay(100, cts.Token);
            }

            await Assert.That(reopened).IsNotNull();
            open.Add(reopened!);
        }
        finally
        {
            foreach (var stream in open)
            {
                stream.Dispose();
            }

            server.Stop();
        }
    }

    [Test]
    public async Task Web_Events_PollerSurvivesANonSqliteFailure()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("alpha")));
        using var server = await TestServers.StartAsync(db.Store, PollInterval);
        try
        {
            using var http = Client(server);
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));

            using var response = await http.GetAsync("api/events", HttpCompletionOption.ResponseHeadersRead, cts.Token);
            await Assert.That((int)response.StatusCode).IsEqualTo(200);
            using var stream = await response.Content.ReadAsStreamAsync(cts.Token);
            using var reader = new StreamReader(stream, Encoding.UTF8);

            var (_, baseline) = await ReadEventsAsync(reader, 1, cts.Token);
            var start = ParseRevision(baseline[0]);
            await Assert.That(start).IsEqualTo(db.Store.Revision());

            // The poller's next tick throws something it does not name; the tick after that sees a bump.
            // A poll loop that dies on the first exception never emits again.
            var injected = start + 5;
            var ticks = 0;
            server.RevisionReader = () =>
            {
                if (Interlocked.Increment(ref ticks) == 1)
                {
                    throw new InvalidOperationException("injected counter failure");
                }

                return injected;
            };

            var (_, later) = await ReadEventsAsync(reader, 1, cts.Token);
            await Assert.That(ParseRevision(later[0])).IsEqualTo(injected);
            await Assert.That(ticks).IsGreaterThanOrEqualTo(2);
        }
        finally
        {
            server.Stop();
        }
    }

    [Test]
    public async Task Web_Stop_IsIdempotent()
    {
        using var db = new TempDb();
        var server = await TestServers.StartAsync(db.Store, PollInterval);
        server.Stop();
        server.Stop();
        server.Dispose();
        server.Dispose();
        await Task.CompletedTask;
    }

    private sealed record SseEvent(string? Name, string? Id, List<string> Data);

    private static long ParseRevision(SseEvent @event) =>
        long.Parse(string.Join("\n", @event.Data), NumberStyles.Integer, CultureInfo.InvariantCulture);

    /// <summary>
    /// Reads Server-Sent Events until <paramref name="wanted"/> complete events have arrived. Comment
    /// lines (keepalive) and the retry preamble are collected in the first list.
    /// </summary>
    private static async Task<(List<string> Preamble, List<SseEvent> Events)> ReadEventsAsync(
        StreamReader reader,
        int wanted,
        CancellationToken token,
        TimeSpan? cap = null)
    {
        var limit = cap ?? TimeSpan.FromSeconds(10);
        var preamble = new List<string>();
        var events = new List<SseEvent>();
        string? name = null;
        string? id = null;
        var data = new List<string>();

        while (events.Count < wanted)
        {
            var line = await reader.ReadLineAsync(token).AsTask().WaitAsync(limit, token);
            if (line is null)
            {
                throw new InvalidOperationException($"the event stream ended after {events.Count} of {wanted} events");
            }

            if (line.StartsWith(':'))
            {
                preamble.Add(line);
                continue;
            }

            if (line.Length == 0)
            {
                if (name is not null || data.Count > 0)
                {
                    events.Add(new SseEvent(name, id, data));
                    name = null;
                    id = null;
                    data = new List<string>();
                }

                continue;
            }

            var colon = line.IndexOf(':');
            var field = colon < 0 ? line : line[..colon];
            var value = colon < 0 ? string.Empty : line[(colon + 1)..].TrimStart(' ');
            switch (field)
            {
                case "event":
                    name = value;
                    break;
                case "id":
                    id = value;
                    break;
                case "data":
                    data.Add(value);
                    break;
                case "retry":
                    preamble.Add($"retry: {value}");
                    break;
            }
        }

        return (preamble, events);
    }
}
