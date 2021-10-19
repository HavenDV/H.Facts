namespace H.Facts;

internal class Sensor
{
    public event EventHandler<Fact> FactReceived;

    protected void OnFactReceived(Fact value)
    {
        FactReceived?.Invoke(this, value);
    }
}
