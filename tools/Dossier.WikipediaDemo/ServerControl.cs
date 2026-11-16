using System.Net;
using System.Net.Sockets;

namespace Dossier.WikipediaDemo;

/// <summary>Loopback port probing and readiness checks for <c>dossier serve</c>.</summary>
internal static class ServerControl
{
    private static readonly IPAddress Loopback = IPAddress.Parse("127.0.0.1");

    public static async Task<bool> IsListeningAsync(int port)
    {
        using var client = new TcpClient();
        using var timeout = new CancellationTokenSource(TimeSpan.FromMilliseconds(500));
        try
        {
            await client.ConnectAsync(Loopback, port, timeout.Token);
            return true;
        }
        catch
        {
            return false;
        }
    }

    /// <summary>The first free port from <paramref name="start"/> up to 25 ahead.</summary>
    public static async Task<int> FreePortAsync(int start)
    {
        for (var port = start; port < start + 25; port++)
        {
            if (!await IsListeningAsync(port))
            {
                return port;
            }
        }

        throw new DemoFailure($"no free port near {start}");
    }

    /// <summary>Poll <c>/api/subjects</c> until the server answers, or fail after 15 seconds.</summary>
    public static async Task WaitForServerAsync(int port)
    {
        var deadline = DateTime.UtcNow.AddSeconds(15);
        using var http = new HttpClient { Timeout = TimeSpan.FromSeconds(1) };
        while (DateTime.UtcNow < deadline)
        {
            try
            {
                using var response = await http.GetAsync($"http://127.0.0.1:{port}/api/subjects");
                if (response.IsSuccessStatusCode)
                {
                    return;
                }
            }
            catch
            {
                // not up yet
            }

            await Task.Delay(150);
        }

        throw new DemoFailure($"dossier serve did not answer on port {port}");
    }

    /// <summary>The <c>/api/graph</c> status, or -1 when the probe itself failed.</summary>
    public static async Task<int> GraphStatusAsync(int port)
    {
        try
        {
            using var http = new HttpClient { Timeout = TimeSpan.FromSeconds(2) };
            using var response = await http.GetAsync($"http://127.0.0.1:{port}/api/graph");
            return (int)response.StatusCode;
        }
        catch
        {
            return -1;
        }
    }
}
