using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

public sealed class ConcurrencyTests
{
    /// <summary>
    /// Many independent stores written, read and torn down at once. A process-wide
    /// SqliteConnection.ClearAllPools() in this path disposes pooled native handles
    /// that other stores are acquiring, raising ObjectDisposedException.
    /// </summary>
    [Test]
    public async Task SeparateStores_WriteReadAndDisposeConcurrently_NeverThrow()
    {
        const int workers = 16;
        const int iterations = 25;
        using var gate = new Barrier(workers);

        var tasks = Enumerable.Range(0, workers).Select(worker => Task.Factory.StartNew(() =>
        {
            gate.SignalAndWait();
            for (var i = 0; i < iterations; i++)
            {
                using var db = new TempDb();
                var ids = db.Store.PostFacts(Fixtures.Post($"Subject{worker}-{i}", Fixtures.Fact($"fact {worker} {i}")))
                    .Response.Facts.Select(f => f.Id).ToList();
                using var connection = db.Store.OpenConnection();
                var count = Fixtures.Count(connection, "SELECT COUNT(*) FROM facts");
                if (count != 1 || ids.Count != 1)
                {
                    throw new InvalidOperationException($"Expected 1 fact, saw {count}.");
                }
            }
        }, TaskCreationOptions.LongRunning)).ToArray();

        await Task.WhenAll(tasks);
        await Assert.That(tasks.All(t => t.IsCompletedSuccessfully)).IsTrue();
    }
}
