using H.World.Models;

namespace H.World.Services;

public class Physics
{
    public void Update(TimeSpan timeSpan, PlanetarySystem planetarySystem)
    {
        foreach (var planet in planetarySystem.Objects.OfType<Planet>())
        {
            var angleInRadians =
                planet.InitialAngleInRadians +
                planet.AngleSpeedInRadiansPerSecond * timeSpan.TotalSeconds;
            
            planet.X = planet.CenterX + planet.Distance * Math.Cos(angleInRadians);
            planet.Y = planet.CenterY + planet.Distance * Math.Sin(angleInRadians);
        }
        foreach (var asteroid in planetarySystem.Objects.OfType<Asteroid>())
        {
            var angleInRadians =
                asteroid.InitialAngleInRadians +
                asteroid.AngleSpeedInRadiansPerSecond * timeSpan.TotalSeconds;
            
            asteroid.X = asteroid.CenterX + asteroid.Distance * Math.Cos(angleInRadians);
            asteroid.Y = asteroid.CenterY + asteroid.Distance * Math.Sin(angleInRadians);
        }
    }
}