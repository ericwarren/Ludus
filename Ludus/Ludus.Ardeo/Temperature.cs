namespace Ludus.Ardeo;

internal sealed class Temperature
{
    private const double AbsoluteZeroCelsius = -273.15;

    private readonly double _celsius;

    private Temperature(double celsius)
    {
        if (celsius < AbsoluteZeroCelsius)
        {
            throw new ArgumentOutOfRangeException(
                nameof(celsius),
                celsius,
                $"Temperature cannot be below absolute zero ({AbsoluteZeroCelsius} °C).");
        }

        _celsius = celsius;
    }

    private static Temperature Create(
        double celsius,
        string paramName,
        double originalValue,
        string limitDescription)
    {
        try
        {
            return new Temperature(celsius);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            throw new ArgumentOutOfRangeException(
                paramName,
                originalValue,
                $"Temperature cannot be below absolute zero ({limitDescription}).");
        }
    }

    public static Temperature FromCelsius(double celsius) =>
        Create(celsius, nameof(celsius), celsius, "-273.15 °C");

    public static Temperature FromFahrenheit(double fahrenheit) =>
        Create((fahrenheit - 32) * 5.0 / 9.0, nameof(fahrenheit), fahrenheit, "-459.67 °F");

    public static Temperature FromKelvin(double kelvin) =>
        Create(kelvin + AbsoluteZeroCelsius, nameof(kelvin), kelvin, "0 K");

    public double Celsius => _celsius;
    public double Fahrenheit => _celsius * 9.0 / 5.0 + 32;
    public double Kelvin => _celsius - AbsoluteZeroCelsius;
}
