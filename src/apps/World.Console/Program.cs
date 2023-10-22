using H.World;
using H.World.Console;
using H.World.Services;
using Spectre.Console;

using var cancellationTokenSource = new CancellationTokenSource();
var cancellationToken = cancellationTokenSource.Token;

var canvas = new Canvas(40, 40);
var planetarySystem = WorldBuilder.Build();
var time = new Time();
var runTask = time.RunAsync(planetarySystem, cancellationToken);

await AnsiConsole.Live(canvas).StartAsync(async context => 
{
    while (!cancellationToken.IsCancellationRequested)
    {
        canvas.DrawPlanetarySystem(planetarySystem);
        context.Refresh();
        
        await Task.Delay(TimeSpan.FromMilliseconds(15));
    }
});
await runTask;