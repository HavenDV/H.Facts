using H.World.Models;

namespace H.World.Services;

public class Time
{
    public DateTime StartTime { get; } = DateTime.Now;
    private Physics Physics { get; } = new();

    public async Task RunAsync(
        PlanetarySystem planetarySystem,
        CancellationToken cancellationToken = default)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            Update(planetarySystem);
            
            await Task.Delay(TimeSpan.FromMilliseconds(15), cancellationToken);
        }
    }
    
    private void Update(PlanetarySystem planetarySystem)
    {
        var timeSpan = DateTime.Now.Subtract(StartTime);
        
        Physics.Update(timeSpan, planetarySystem);
    }
}