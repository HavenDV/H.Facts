namespace H.World.Models;

public class Planet : Object
{
    public required double AngleSpeedInRadiansPerSecond { get; init; }
    public required double Distance { get; init; }
    public required double InitialAngleInRadians { get; init; }
    public required double CenterX { get; init; }
    public required double CenterY { get; init; }
}