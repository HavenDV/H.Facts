namespace H.Facts;

public class Brain
{
    #region Properties

    private Memory Memory { get; } = new();
    private List<Sensor> Sensors { get; } = new();

    #endregion

    #region Methods

    public void AddSensor(Sensor sensor)
    {
        sensor = sensor ?? throw new ArgumentNullException(nameof(sensor));

        Sensors.Add(sensor);
        sensor.FactReceived += Sensor_FactReceived;
    }

    #endregion

    #region Event Handlers

    private void Sensor_FactReceived(object sender, Sensor.FactReceivedEventArgs args)
    {
        Memory.Facts.Add(args.Fact);
    }

    #endregion
}
