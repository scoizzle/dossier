using System.Collections.Concurrent;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Text;
using System.Text.Json;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

/// <summary>
/// Many independent <see cref="DossierStore"/> instances on one database file, writing at the same
/// time, with the live channel watching. Each writer opens its own connection per call
/// (WAL, busy_timeout=5000), which is how separate `dossier mcp` processes behave.
/// </summary>
public sealed class MultiWriterTests
{
    /// <summary>Writers are released together so their transactions actually overlap.</summary>
    private static Task[] StartTogether(int writers, Action<int> body)
    {
        // Not disposed: the writers may still be inside SignalAndWait when this method returns.
        var gate = new Barrier(writers);
        return Enumerable.Range(0, writers)
            .Select(writer => Task.Factory.StartNew(
                () =>
                {
                    gate.SignalAndWait();
                    body(writer);
                },
                TaskCreationOptions.LongRunning))
            .ToArray();
    }

    private static string Describe(IEnumerable<Exception> errors) =>
        string.Join(" | ", errors.Select(error => $"{error.GetType().Name}: {error.Message}"));

    [Test]
    public async Task Writers_DistinctFacts_AllLand()
    {
        using var db = new TempDb();
        const int writers = 4;
        const int perWriter = 50;
        var before = db.Store.Revision();
        var errors = new ConcurrentQueue<Exception>();
        // Each writer's store is opened before the barrier: connection setup is not the overlap
        // the barrier exists to create.
        var stores = Enumerable.Range(0, writers).Select(_ => new DossierStore(db.DbPath)).ToArray();

        var tasks = StartTogether(writers, writer =>
        {
            try
            {
                var store = stores[writer];
                for (var index = 0; index < perWriter; index++)
                {
                    // Two subjects are shared by every writer; the third is the writer's own.
                    var subject = index % 3 == 0 ? $"Agent/{writer}" : index % 2 == 0 ? "Shared/One" : "Shared/Two";
                    store.PostFacts(Fixtures.Post(subject, Fixtures.Fact($"w{writer}-fact-{index:00}")));
                }
            }
            catch (Exception exception)
            {
                errors.Enqueue(exception);
            }
        });
        await Task.WhenAll(tasks);

        await Assert.That(Describe(errors)).IsEqualTo(string.Empty);

        using var connection = db.Store.OpenConnection();
        var total = Fixtures.Count(connection, "SELECT COUNT(*) FROM facts WHERE text LIKE 'w%-fact-%'");
        var distinct = Fixtures.Count(connection, "SELECT COUNT(DISTINCT text) FROM facts WHERE text LIKE 'w%-fact-%'");
        await Assert.That(total).IsEqualTo(writers * perWriter);
        await Assert.That(distinct).IsEqualTo(writers * perWriter);

        var subjects = Fixtures.Count(connection, "SELECT COUNT(*) FROM subjects");
        await Assert.That(subjects).IsEqualTo(6);
        // Every accepted fact insert fires trg_facts_insert, so the counter moves at least once per fact.
        await Assert.That(db.Store.Revision()).IsGreaterThanOrEqualTo(before + (writers * perWriter));
    }

    [Test]
    public async Task Writers_IdenticalFact_DedupesToOne()
    {
        using var db = new TempDb();
        const int writers = 8;
        const int rounds = 20;
        var errors = new ConcurrentQueue<Exception>();
        var stores = Enumerable.Range(0, writers).Select(_ => new DossierStore(db.DbPath)).ToArray();

        for (var round = 0; round < rounds; round++)
        {
            var text = $"identical-round-{round:00}";
            var tasks = StartTogether(writers, writer =>
            {
                try
                {
                    var store = stores[writer];
                    store.PostFacts(Fixtures.Post("Dedupe/Round", Fixtures.Fact(text)));
                }
                catch (Exception exception)
                {
                    errors.Enqueue(exception);
                }
            });
            await Task.WhenAll(tasks);

            using var connection = db.Store.OpenConnection();
            var live = Fixtures.Count(
                connection,
                "SELECT COUNT(*) FROM facts WHERE subject_id = (SELECT id FROM subjects WHERE name = 'Dedupe/Round') AND text = $text AND status = 'live'",
                ("$text", text));
            await Assert.That($"round {round}: live={live} errors={Describe(errors)}").IsEqualTo($"round {round}: live=1 errors=");
        }

        using var final = db.Store.OpenConnection();
        await Assert.That(Fixtures.Count(final, "SELECT COUNT(*) FROM facts")).IsEqualTo(rounds);
    }

    [Test]
    public async Task Writers_SameKeySlot_EndsConsistent()
    {
        using var db = new TempDb();
        const int writers = 4;
        const int rounds = 10;
        var errors = new ConcurrentQueue<Exception>();
        var stores = Enumerable.Range(0, writers).Select(_ => new DossierStore(db.DbPath)).ToArray();
        using var connection = db.Store.OpenConnection();

        for (var round = 0; round < rounds; round++)
        {
            // A fresh subject and key each round, so every round starts with exactly one empty slot.
            var subject = $"Slot/Subject/{round:00}";
            var key = $"status-{round:00}";
            var statuses = new ConcurrentQueue<string>();

            var tasks = StartTogether(writers, writer =>
            {
                try
                {
                    var result = stores[writer].PostFacts(Fixtures.Post(subject, Fixtures.Fact($"slot-value-{writer}", key: key)));
                    statuses.Enqueue(result.Response.Facts[0].Status);
                }
                catch (Exception exception)
                {
                    errors.Enqueue(exception);
                }
            });
            await Task.WhenAll(tasks);

            await Assert.That($"round {round}: {Describe(errors)}").IsEqualTo($"round {round}: ");

            var slotFact = Fixtures.Scalar(
                connection,
                "SELECT fact_id FROM slots WHERE subject_id = (SELECT id FROM subjects WHERE name = $subject) AND kind = 'note' AND key = $key",
                ("$subject", subject),
                ("$key", key));
            await Assert.That(slotFact is string).IsTrue();

            // Single-writer semantics: the newest post owns the slot and the replaced fact is superseded.
            var live = Fixtures.Count(
                connection,
                "SELECT COUNT(*) FROM facts WHERE subject_id = (SELECT id FROM subjects WHERE name = $subject) AND kind = 'note' AND key = $key AND status = 'live'",
                ("$subject", subject),
                ("$key", key));
            var superseded = Fixtures.Count(
                connection,
                "SELECT COUNT(*) FROM facts WHERE subject_id = (SELECT id FROM subjects WHERE name = $subject) AND kind = 'note' AND key = $key AND status = 'superseded'",
                ("$subject", subject),
                ("$key", key));
            var slotLive = Fixtures.Count(
                connection,
                "SELECT COUNT(*) FROM facts WHERE id = $id AND status = 'live'",
                ("$id", slotFact));
            await Assert.That(live).IsEqualTo(1);
            await Assert.That(slotLive).IsEqualTo(1);
            await Assert.That(live + superseded).IsEqualTo(writers);

            // The first writer to reach the empty slot creates it; every later writer replaces it.
            var posted = statuses.ToArray();
            await Assert.That($"round {round}: new={posted.Count(status => status == "new")}")
                .IsEqualTo($"round {round}: new=1");
            await Assert.That($"round {round}: replaced={posted.Count(status => status == "replaced")}")
                .IsEqualTo($"round {round}: replaced={writers - 1}");
        }
    }

    [Test]
    public async Task Writers_WhileStreaming_StreamReachesFinalRevision()
    {
        using var db = new TempDb();
        const int writers = 4;
        const int perWriter = 25;
        using var server = await TestServers.StartAsync(db.Store, TimeSpan.FromMilliseconds(20));
        try
        {
            using var http = new HttpClient { BaseAddress = new Uri($"http://127.0.0.1:{server.Port}/") };
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

            using var response = await http.GetAsync("api/events", HttpCompletionOption.ResponseHeadersRead, cts.Token);
            await Assert.That((int)response.StatusCode).IsEqualTo(200);
            using var stream = await response.Content.ReadAsStreamAsync(cts.Token);
            using var reader = new StreamReader(stream, Encoding.UTF8);

            // The baseline event proves the stream is live before the first write.
            await ReadRevisionAsync(reader, expected: null, TimeSpan.FromSeconds(5), cts.Token);

            var graphStatuses = new ConcurrentQueue<int>();
            var graphUrl = "api/graph?depth=1&facts=true&max_nodes=500";

            Task<int> SampleGraph()
            {
                var sample = http.GetAsync(graphUrl, cts.Token);
                return sample.ContinueWith(
                    task =>
                    {
                        using var reply = task.Result;
                        graphStatuses.Enqueue((int)reply.StatusCode);
                        return (int)reply.StatusCode;
                    },
                    TaskScheduler.Default);
            }

            var errors = new ConcurrentQueue<Exception>();
            var stores = Enumerable.Range(0, writers).Select(_ => new DossierStore(db.DbPath)).ToArray();
            var tasks = StartTogether(writers, writer =>
            {
                try
                {
                    var store = stores[writer];
                    for (var index = 0; index < perWriter; index++)
                    {
                        store.PostFacts(Fixtures.Post("Stream/Writers", Fixtures.Fact($"stream-w{writer}-{index:00}")));
                    }
                }
                catch (Exception exception)
                {
                    errors.Enqueue(exception);
                }
            });

            var writersDone = Task.WhenAll(tasks);
            // One graph request in flight at a time: the sampler must not build a backlog.
            var samples = new List<Task<int>>();
            var inFlight = SampleGraph();
            while (!writersDone.IsCompleted)
            {
                if (inFlight.IsCompleted)
                {
                    samples.Add(inFlight);
                    inFlight = SampleGraph();
                }

                await Task.Delay(10, cts.Token);
            }

            await writersDone;
            await Assert.That(Describe(errors)).IsEqualTo(string.Empty);
            samples.Add(inFlight);

            foreach (var sample in samples)
            {
                await Assert.That(await sample).IsEqualTo(200);
            }

            await Assert.That(graphStatuses.Count).IsGreaterThan(0);
            await Assert.That(graphStatuses.All(status => status == 200)).IsTrue();

            var final = db.Store.Revision();
            var delivered = await ReadRevisionAsync(reader, expected: final, TimeSpan.FromSeconds(5), cts.Token);
            await Assert.That(delivered).IsEqualTo(final);
        }
        finally
        {
            server.Stop();
        }
    }

    /// <summary>
    /// Reads SSE frames until the revision payload equals <paramref name="expected"/>, or one frame
    /// when <paramref name="expected"/> is null. Comments and the retry preamble are skipped, and so is
    /// every non-revision frame: the live channel also carries <c>changes</c> and <c>reset</c> events
    /// whose <c>data</c> is JSON, not a counter.
    /// </summary>
    private static async Task<long> ReadRevisionAsync(StreamReader reader, long? expected, TimeSpan cap, CancellationToken token)
    {
        var stopwatch = Stopwatch.StartNew();
        var data = new List<string>();
        string? name = null;

        while (true)
        {
            var line = await reader.ReadLineAsync(token).AsTask().WaitAsync(cap, token);
            if (line is null)
            {
                throw new InvalidOperationException("the event stream ended before the expected revision arrived");
            }

            if (line.Length != 0)
            {
                if (line.StartsWith("event:", StringComparison.Ordinal))
                {
                    name = line[6..].Trim();
                }
                else if (line.StartsWith("data:", StringComparison.Ordinal))
                {
                    data.Add(line[5..].Trim());
                }

                continue;
            }

            if (data.Count == 0 || name != "revision")
            {
                data.Clear();
                name = null;
                continue;
            }

            var revision = long.Parse(string.Join("\n", data), NumberStyles.Integer, CultureInfo.InvariantCulture);
            data.Clear();
            name = null;
            if (expected is null || revision == expected || stopwatch.Elapsed > cap)
            {
                return revision;
            }
        }
    }
}
