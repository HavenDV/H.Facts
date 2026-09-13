namespace H.Facts;

public partial class Sensor
{
    public IReadOnlyCollection<Api> Apis = new List<Api>();
}

public class Api
{
    public object? Input;
    public object? Output;
    public string Description { get; set; } = string.Empty;
}
