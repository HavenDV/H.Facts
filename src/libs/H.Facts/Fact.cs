namespace H.Facts;

public record Fact(
    string ObjectName,
    List<DateTimeProperty> DateTimeProperties,
    List<DoubleProperty> DoubleProperties)
{
    public Fact(string objectName) : this(
        objectName,
        new(),
        new())
    {
    }
}
