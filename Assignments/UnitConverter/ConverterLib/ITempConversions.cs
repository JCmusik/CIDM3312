namespace ConverterLib
{
    interface ITempConversions
    {
        // Celsius to Fahrenheit
        decimal CelsiusToFahrenheit(int TempC);

        // Fahrenheit to Celsius
        decimal FahrenheitToCelsius(int TempF);

        // Celsius to Kelvin 
        decimal CelsiusToKelvin(int TempC);

        // Kelvin to Celsius
        decimal KelvinToCelsius(int TempK);

        // Fahernheit to Kelvin
        decimal FahernheitToKelvin(int TempF);

        // Kelvin to Fahernheit
        decimal KelvinToFahrenheit(int TempK);

    }
}