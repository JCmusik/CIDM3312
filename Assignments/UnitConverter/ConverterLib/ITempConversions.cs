namespace ConverterLib
{
    public interface ITempConversions
    {
        // Celsius to Fahrenheit
        decimal CelsiusToFahrenheit(decimal TempC);

        // Fahrenheit to Celsius
        decimal FahrenheitToCelsius(decimal TempF);

        // Celsius to Kelvin 
        decimal CelsiusToKelvin(decimal TempC);

        // Kelvin to Celsius
        decimal KelvinToCelsius(decimal TempK);

        // Fahernheit to Kelvin
        decimal FahernheitToKelvin(decimal TempF);

        // Kelvin to Fahernheit
        decimal KelvinToFahrenheit(decimal TempK);

    }
}