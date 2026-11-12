using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using Microsoft.Data.Sqlite;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

/// <summary>
/// The live journal channel: after the baseline <c>revision</c> frame, <c>/api/events</c> sends the
/// journal behind the client's cursor as <c>changes</c> frames whose SSE <c>id</c> is the next cursor,
/// and a <c>reset</c> when that cursor cannot be honoured.
/// </summary>
public sealed class ChangeStreamTests
{
    private static readonly TimeSpan PollInterval = TimeSpan.FromMilliseconds(20);

    private static HttpClient Client(WebServer server) =>
        new() { BaseAddress = new Uri($"http://127.0.0.1:{server.Port}/") };

    private sealed record SseFrame(string? Name, string? Id, List<string> Data)
    {
        public JsonElement Body => JsonDocument.Parse(string.Join("\n", Data)).RootElement;
    }

    /// <summary>Reads complete SSE frames until <paramref name="wanted"/> have arrived; comments are skipped.</summary>
    private static async Task<List<SseFrame>> ReadFramesAsync(StreamReader reader, int wanted, CancellationToken token)
    {
        var frames = new List<SseFrame>();
        string? name = null;
        string? id = null;
        var data = new List<string>();

        while (frames.Count < wanted)
        {
            var line = await reader.ReadLineAsync(token).AsTask().WaitAsync(TimeSpan.FromSeconds(20), token);
            if (line is null)
            {
                throw new InvalidOperationException($"the stream ended after {frames.Count} of {wanted} frames");
            }

            if (line.Length == 0)
            {
                if (name is not null || data.Count > 0)
                {
                    frames.Add(new SseFrame(name, id, data));
                    name = null;
                    id = null;
                    data = new List<string>();
                }

                continue;
            }

            if (line.StartsWith(':'))
            {
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
            }
        }

        return frames;
    }

    private static long Long(string? text) =>
        long.Parse(text ?? throw new InvalidOperationException("missing value"), NumberStyles.Integer, CultureInfo.InvariantCulture);

    [Test]
    public async Task Stream_SendsChangesAfterTheRevision()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("alpha")));
        using var server = await TestServers.StartAsync(db.Store, PollInterval);
        using var http = Client(server);
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(20));

        using var response = await http.GetAsync("api/events", HttpCompletionOption.ResponseHeadersRead, cts.Token);
        using var reader = new StreamReader(await response.Content.ReadAsStreamAsync(cts.Token), Encoding.UTF8);

        var baseline = await ReadFramesAsync(reader, 1, cts.Token);
        await Assert.That(baseline[0].Name).IsEqualTo("revision");
        await Assert.That(baseline[0].Id).IsNull();
        var from = Long(string.Join("\n", baseline[0].Data));

        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("beta")));

        // The revision frame is always first, then the journal page behind it.
        var frames = await ReadFramesAsync(reader, 2, cts.Token);
        await Assert.That(frames[0].Name).IsEqualTo("revision");
        await Assert.That(frames[1].Name).IsEqualTo("changes");

        var body = frames[1].Body;
        var next = body.GetProperty("next").GetInt64();
        await Assert.That(body.GetProperty("from").GetInt64()).IsEqualTo(from);
        await Assert.That(body.GetProperty("to").GetInt64()).IsEqualTo(next);
        await Assert.That(Long(frames[1].Id)).IsEqualTo(next);
        await Assert.That(Long(string.Join("\n", frames[0].Data))).IsEqualTo(next);

        var changes = body.GetProperty("changes");
        await Assert.That(changes.GetArrayLength()).IsEqualTo(1);
        var change = changes[0];
        await Assert.That(change.GetProperty("tbl").GetString()).IsEqualTo("facts");
        await Assert.That(change.GetProperty("op").GetString()).IsEqualTo("insert");
        await Assert.That(change.GetProperty("text").GetString()).IsEqualTo("beta");
        await Assert.That(change.GetProperty("actor").GetString()).IsEqualTo("dossier-cli");
        await Assert.That(change.GetProperty("seq").GetInt64()).IsEqualTo(next);
    }

    [Test]
    public async Task Stream_ResumesFromLastEventId()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("alpha")));
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("beta")));
        using var server = await TestServers.StartAsync(db.Store, PollInterval);
        using var http = Client(server);
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(20));

        long cursor;
        using (var first = await http.GetAsync("api/events", HttpCompletionOption.ResponseHeadersRead, cts.Token))
        {
            using var reader = new StreamReader(await first.Content.ReadAsStreamAsync(cts.Token), Encoding.UTF8);
            await ReadFramesAsync(reader, 1, cts.Token);
            db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("delta")));
            var frames = await ReadFramesAsync(reader, 2, cts.Token);
            cursor = Long(frames[1].Id);
            await Assert.That(cursor).IsEqualTo(db.Store.Revision());
        }

        // A reconnect carries the last id it saw. ?since=0 is there to prove the header wins: honouring
        // it would replay the whole journal from seq 1.
        using var request = new HttpRequestMessage(HttpMethod.Get, "api/events?since=0");
        request.Headers.TryAddWithoutValidation("Last-Event-ID", cursor.ToString(CultureInfo.InvariantCulture));
        using var response = await http.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cts.Token);
        using var resumed = new StreamReader(await response.Content.ReadAsStreamAsync(cts.Token), Encoding.UTF8);

        // The poller may still be reporting the pre-connect revision: wait until it has caught up with
        // the cursor we resumed from, so the next write is the only thing that can wake the stream.
        while (true)
        {
            var frame = (await ReadFramesAsync(resumed, 1, cts.Token))[0];
            if (frame.Name == "revision" && Long(string.Join("\n", frame.Data)) == cursor)
            {
                break;
            }
        }

        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("epsilon")));
        var next = await ReadFramesAsync(resumed, 2, cts.Token);
        await Assert.That(next[1].Name).IsEqualTo("changes");
        var body = next[1].Body;
        await Assert.That(body.GetProperty("from").GetInt64()).IsEqualTo(cursor);
        await Assert.That(body.GetProperty("changes").GetArrayLength()).IsEqualTo(1);
        await Assert.That(body.GetProperty("changes")[0].GetProperty("seq").GetInt64()).IsEqualTo(cursor + 1);
        await Assert.That(body.GetProperty("changes")[0].GetProperty("text").GetString()).IsEqualTo("epsilon");
        await Assert.That(Long(next[1].Id)).IsEqualTo(cursor + 1);
    }

    [Test]
    public async Task Stream_SinceReplaysHistory()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("alpha"), Fixtures.Fact("beta")));
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("gamma")));
        var head = db.Store.Revision();
        using var server = await TestServers.StartAsync(db.Store, PollInterval);
        using var http = Client(server);
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(20));

        // Nothing is written after connect: the replay has to arrive without a change to trigger it.
        using var response = await http.GetAsync("api/events?since=0", HttpCompletionOption.ResponseHeadersRead, cts.Token);
        using var reader = new StreamReader(await response.Content.ReadAsStreamAsync(cts.Token), Encoding.UTF8);

        var frames = await ReadFramesAsync(reader, 2, cts.Token);
        await Assert.That(frames[0].Name).IsEqualTo("revision");
        await Assert.That(frames[1].Name).IsEqualTo("changes");
        var body = frames[1].Body;
        await Assert.That(body.GetProperty("from").GetInt64()).IsEqualTo(0);
        await Assert.That(body.GetProperty("to").GetInt64()).IsEqualTo(head);

        var seqs = body.GetProperty("changes").EnumerateArray().Select(row => row.GetProperty("seq").GetInt64()).ToList();
        await Assert.That(seqs.SequenceEqual(Enumerable.Range(1, (int)head).Select(value => (long)value))).IsTrue();
        await Assert.That(body.GetProperty("changes").EnumerateArray()
            .Select(row => row.GetProperty("text").GetString()).Where(text => text is not null).ToList()
            .SequenceEqual(new List<string?> { "alpha", "beta", "gamma" })).IsTrue();
    }

    [Test]
    public async Task Stream_DrainsBeyondOnePage()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("alpha")));
        using var server = await TestServers.StartAsync(db.Store, PollInterval);
        using var http = Client(server);
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(60));

        using var response = await http.GetAsync("api/events", HttpCompletionOption.ResponseHeadersRead, cts.Token);
        using var reader = new StreamReader(await response.Content.ReadAsStreamAsync(cts.Token), Encoding.UTF8);
        await ReadFramesAsync(reader, 1, cts.Token);
        var baseline = db.Store.Revision();

        // One transaction, so the poller either sees none of it or all 450 rows at once.
        var facts = Enumerable.Range(0, 450).Select(index => Fixtures.Fact($"burst-{index:000}")).ToArray();
        db.Store.PostFacts(Fixtures.Post("Widget", facts));

        var frames = await ReadFramesAsync(reader, 4, cts.Token);
        await Assert.That(frames[0].Name).IsEqualTo("revision");
        await Assert.That(frames.Skip(1).All(frame => frame.Name == "changes")).IsTrue();

        var sizes = frames.Skip(1).Select(frame => frame.Body.GetProperty("changes").GetArrayLength()).ToList();
        await Assert.That(sizes.SequenceEqual(new[] { 200, 200, 50 })).IsTrue();

        // Contiguous: each frame starts where the previous cursor ended.
        var cursor = baseline;
        foreach (var frame in frames.Skip(1))
        {
            var body = frame.Body;
            await Assert.That(body.GetProperty("from").GetInt64()).IsEqualTo(cursor);
            cursor = body.GetProperty("next").GetInt64();
            await Assert.That(Long(frame.Id)).IsEqualTo(cursor);
        }

        await Assert.That(cursor).IsEqualTo(baseline + 450);
    }

    [Test]
    public async Task Stream_ResetsWhenThePointFellOutOfRetention()
    {
        using var db = new TempDb();
        var facts = Enumerable.Range(0, 12).Select(index => Fixtures.Fact($"kept-{index:00}")).ToArray();
        db.Store.PostFacts(Fixtures.Post("Widget", facts));

        // A retention this small is the only way a test can prune; the production window is 100k rows.
        using (var connection = db.Store.OpenConnection())
        using (var transaction = connection.BeginTransaction())
        {
            DossierStore.PruneChanges(connection, transaction, db.Store.Revision(), retention: 5, slack: 1);
            transaction.Commit();
        }

        using var server = await TestServers.StartAsync(db.Store, PollInterval);
        using var http = Client(server);
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(20));

        using var response = await http.GetAsync("api/events?since=0", HttpCompletionOption.ResponseHeadersRead, cts.Token);
        using var reader = new StreamReader(await response.Content.ReadAsStreamAsync(cts.Token), Encoding.UTF8);

        var frames = await ReadFramesAsync(reader, 2, cts.Token);
        await Assert.That(frames[0].Name).IsEqualTo("revision");
        await Assert.That(frames[1].Name).IsEqualTo("reset");
        var revision = Long(string.Join("\n", frames[0].Data));
        await Assert.That(revision).IsEqualTo(db.Store.Revision());
        await Assert.That(Long(frames[1].Id)).IsEqualTo(revision);
        await Assert.That(Long(string.Join("\n", frames[1].Data))).IsEqualTo(revision);
    }

    [Test]
    public async Task Stream_ResetsBeyondTheDrainCap()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("alpha")));
        using var server = await TestServers.StartAsync(db.Store, PollInterval);
        using var http = Client(server);
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(120));

        using var response = await http.GetAsync("api/events", HttpCompletionOption.ResponseHeadersRead, cts.Token);
        using var reader = new StreamReader(await response.Content.ReadAsStreamAsync(cts.Token), Encoding.UTF8);
        await ReadFramesAsync(reader, 1, cts.Token);

        // More pending rows than one tick may deliver.
        var facts = Enumerable.Range(0, 5001).Select(index => Fixtures.Fact($"flood-{index:0000}")).ToArray();
        db.Store.PostFacts(Fixtures.Post("Widget", facts));

        var frames = await ReadFramesAsync(reader, 27, cts.Token);
        await Assert.That(frames[0].Name).IsEqualTo("revision");
        var pages = frames.Skip(1).Take(25).ToList();
        await Assert.That(pages.All(frame => frame.Name == "changes")).IsTrue();
        await Assert.That(pages.All(frame => frame.Body.GetProperty("changes").GetArrayLength() == 200)).IsTrue();
        await Assert.That(frames[^1].Name).IsEqualTo("reset");

        // The reset names the revision, and the cursor it leaves is the same value.
        var revision = Long(string.Join("\n", frames[0].Data));
        await Assert.That(Long(frames[^1].Id)).IsEqualTo(revision);
        await Assert.That(Long(string.Join("\n", frames[^1].Data))).IsEqualTo(revision);
        await Assert.That(revision).IsEqualTo(db.Store.Revision());
    }

    [Test]
    public async Task Stream_EmptyTickSendsNoChangesFrame()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("alpha")));
        using var server = await TestServers.StartAsync(db.Store, PollInterval);
        using var http = Client(server);
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(20));

        using var response = await http.GetAsync("api/events", HttpCompletionOption.ResponseHeadersRead, cts.Token);
        using var reader = new StreamReader(await response.Content.ReadAsStreamAsync(cts.Token), Encoding.UTF8);
        var baseline = Long(string.Join("\n", (await ReadFramesAsync(reader, 1, cts.Token))[0].Data));
        var from = db.Store.Revision();

        // The poller reports a revision the journal does not contain: a tick with an empty page. The
        // stream must forward the revision and send no changes frame at all.
        var injected = from + 1;
        server.RevisionReader = () => Volatile.Read(ref injected);
        var bumped = await ReadFramesAsync(reader, 1, cts.Token);
        await Assert.That(bumped[0].Name).IsEqualTo("revision");
        await Assert.That(Long(string.Join("\n", bumped[0].Data))).IsEqualTo(from + 1);
        await Assert.That(baseline).IsEqualTo(from);

        injected = from + 2;
        var second = await ReadFramesAsync(reader, 1, cts.Token);
        await Assert.That(second[0].Name).IsEqualTo("revision");

        // An empty page must not move the journal cursor: a real write still arrives in full.
        server.RevisionReader = () => db.Store.Revision();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("beta")));
        var after = await ReadFramesAsync(reader, 2, cts.Token);
        await Assert.That(after[0].Name).IsEqualTo("revision");
        await Assert.That(after[1].Name).IsEqualTo("changes");
        await Assert.That(after[1].Body.GetProperty("from").GetInt64()).IsEqualTo(from);
        await Assert.That(after[1].Body.GetProperty("changes")[0].GetProperty("text").GetString()).IsEqualTo("beta");
    }

    [Test]
    public async Task Stream_SurvivesJournalReadFailure()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("alpha")));
        using var server = await TestServers.StartAsync(db.Store, PollInterval);
        using var http = Client(server);
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(20));

        // The first journal read throws; that skips one tick, it does not end the stream.
        var calls = 0;
        server.ChangesReader = (since, limit) =>
            Interlocked.Increment(ref calls) == 1
                ? throw new SqliteException("injected journal failure", 5)
                : db.Store.ReadChanges(since, limit);

        using var response = await http.GetAsync("api/events", HttpCompletionOption.ResponseHeadersRead, cts.Token);
        using var reader = new StreamReader(await response.Content.ReadAsStreamAsync(cts.Token), Encoding.UTF8);

        var baseline = await ReadFramesAsync(reader, 1, cts.Token);
        await Assert.That(baseline[0].Name).IsEqualTo("revision");
        await Assert.That(Volatile.Read(ref calls)).IsGreaterThanOrEqualTo(1);

        // The next tick reads the journal again and delivers the write, so the handler survived.
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("beta")));
        var frames = await ReadFramesAsync(reader, 2, cts.Token);
        await Assert.That(frames[0].Name).IsEqualTo("revision");
        await Assert.That(frames[1].Name).IsEqualTo("changes");
        await Assert.That(frames[1].Body.GetProperty("changes")[0].GetProperty("text").GetString()).IsEqualTo("beta");
    }
}
