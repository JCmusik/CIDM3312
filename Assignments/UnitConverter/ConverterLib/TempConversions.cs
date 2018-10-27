using System;

namespace ConverterLib
{
    public class TempConversions : ITempConversions
    {
        // Celsius to Fahrenheit
        public decimal CelsiusToFahrenheit(decimal TempC) => TempC * (9M / 5M) + 32;

        // Fahrenheit to Celsius
        public decimal FahrenheitToCelsius(decimal TempF) => (TempF - 32) / 9M * 5M;

        // Celsius to Kelvin 
        public decimal CelsiusToKelvin(decimal TempC) => TempC + 273.15M;

        // Kelvin to Celsius
        public decimal KelvinToCelsius(decimal TempK) => TempK - 273.15M;

        // Fahernheit to Kelvin
        public decimal FahernheitToKelvin(decimal TempF) => (TempF + 459.67M) * 5M / 9M;

        // Kelvin to Fahernheit
        public decimal KelvinToFahrenheit(decimal TempK) => TempK * (9M / 5M) - 459.67M;

    }
}
