namespace H.Facts;

public class Sensor
{
    public event EventHandler<Fact>? FactReceived;

    public void OnFactReceived(Fact value)
    {
        FactReceived?.Invoke(this, value);
    }
}
