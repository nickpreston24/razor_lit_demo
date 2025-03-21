using CodeMechanic.Diagnostics;
using CodeMechanic.Types;
using Lib.AspNetCore.ServerSentEvents;

namespace razor_lit_demo;

public class RandomNumberWorker : IHostedService
{
    private readonly IServerSentEventsService _sse;

    public RandomNumberWorker(IServerSentEventsService sse)
    {
        _sse = sse;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            var clients = _sse.GetClients();
            if (clients.Any())
            {
                var number = Enumerable
                        .Range(1, 100)
                        .TakeFirstRandom()
                    ;

                Number.Value = number.Dump("random number");

                await _sse.SendEventAsync(
                    new ServerSentEvent
                    {
                        Id = "number",
                        Type = "number",
                        Data = new List<string>
                        {
                            Number.Value.ToString()
                        }
                    },
                    cancellationToken
                );
            }

            await Task.Delay(TimeSpan.FromSeconds(1), cancellationToken);
        }
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}

public static class Number
{
    public static int Value { get; set; } = 1;
}