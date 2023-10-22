using H.World.Models;
using Spectre.Console;
using Object = H.World.Models.Object;

namespace H.World;

public class WorldBuilder
{
    public static PlanetarySystem Build()
    {
        return new PlanetarySystem
        {
            Objects = new List<Object>
            {
                new Planet
                {
                    Name = "Venera",
                    Radius = 1.0,
                    Color = Color.Yellow,
                    AngleSpeedInRadiansPerSecond = 0.2,
                    Distance = 3.0,
                    InitialAngleInRadians = 1.0,
                    CenterX = 20.0,
                    CenterY = 20.0,
                },
                new Planet
                {
                    Name = "Earth",
                    Radius = 1.0,
                    Color = Color.Blue,
                    AngleSpeedInRadiansPerSecond = 0.1,
                    Distance = 5.0,
                    InitialAngleInRadians = 2.0,
                    CenterX = 20.0,
                    CenterY = 20.0,
                },
                new Planet
                {
                    Name = "Mars",
                    Radius = 1.0,
                    Color = Color.Red,
                    AngleSpeedInRadiansPerSecond = 0.05,
                    Distance = 7.0,
                    InitialAngleInRadians = 0.0,
                    CenterX = 20.0,
                    CenterY = 20.0,
                },
                new()
                {
                    Name = "Sun",
                    Radius = 2.0,
                    Color = Color.DarkOrange,
                    X = 20.0,
                    Y = 20.0,
                },
                new Asteroid
                {
                    Name = "Asteroid1",
                    Radius = 1.0,
                    Color = Color.DarkSlateGray2,
                    AngleSpeedInRadiansPerSecond = 0.30,
                    Distance = 31.0,
                    InitialAngleInRadians = 0.0,
                    CenterX = 0.0,
                    CenterY = 0.0,
                },
                new Asteroid
                {
                    Name = "Asteroid2",
                    Radius = 1.0,
                    Color = Color.DarkSlateGray1,
                    AngleSpeedInRadiansPerSecond = 0.40,
                    Distance = 61.0,
                    InitialAngleInRadians = 0.0,
                    CenterX = 60.0,
                    CenterY = 60.0,
                },
                new Asteroid
                {
                    Name = "Asteroid3",
                    Radius = 1.0,
                    Color = Color.DarkSlateGray3,
                    AngleSpeedInRadiansPerSecond = 0.20,
                    Distance = 31.0,
                    InitialAngleInRadians = 0.0,
                    CenterX = 40.0,
                    CenterY = 0.0,
                },
            }
        };
    }
}