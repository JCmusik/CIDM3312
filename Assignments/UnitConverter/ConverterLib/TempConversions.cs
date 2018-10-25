using System;

namespace ConverterLib
{
    public class TempConversions
    {
        // Celsius to Fahrenheit
        public static decimal CelsiusToFahrenheit(int TempC) => TempC * (9M / 5M) + 32;

        // Fahrenheit to Celsius
        public static decimal FahrenheitToCelsius(int TempF) => (TempF - 32) / 9M * 5M;

        // Celsius to Kelvin 
        public static decimal CelsiusToKelvin(int TempC) => TempC + 273.15M;

        // Kelvin to Celsius
        public static decimal KelvinToCelsius(int TempK) => TempK - 273.15M;

        // Fahernheit to Kelvin
        public static decimal FahernheitToKelvin(int TempF) => (TempF + 459.67M) * 5M / 9M;

        // Kelvin to Fahernheit
        public static decimal KelvinToFahrenheit(int TempK) => TempK * (9M / 5M) - 459.67M;

    }
}
