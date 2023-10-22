using Spectre.Console;

namespace H.World.Models;

public class Object
{
    public required string Name { get; init; }
    public required double Radius { get; init; }
    public required Color Color { get; init; }
    public double X { get; set; }
    public double Y { get; set; }
}