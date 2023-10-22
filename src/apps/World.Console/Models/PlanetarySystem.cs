namespace H.World.Models;

public class PlanetarySystem
{
    public IReadOnlyCollection<Object> Objects { get; init; } = new List<Object>();
}