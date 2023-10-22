using H.World.Models;

namespace H.World.Services;

public class Bot
{
    public required Starship Starship { get; init; }
    public DateTime StartTime { get; } = DateTime.Now;

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
        foreach (var planet in planetarySystem.Objects.OfType<Planet>())
        {
            var angleInRadians =
                planet.InitialAngleInRadians +
                planet.AngleSpeedInRadiansPerSecond * timeSpan.TotalSeconds;
            
            planet.X = planet.CenterX + planet.Distance * Math.Cos(angleInRadians);
            planet.Y = planet.CenterY + planet.Distance * Math.Sin(angleInRadians);
        }
    }
}