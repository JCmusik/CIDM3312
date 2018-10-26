using System;
using ConverterLib;

namespace UnitConverterConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var tempConvert = new TempConversions();

            Console.WriteLine(tempConvert.CelsiusToFahrenheit(15));

            Console.WriteLine(tempConvert.FahrenheitToCelsius(59));

            Console.WriteLine(tempConvert.CelsiusToKelvin(15));

            Console.WriteLine(tempConvert.KelvinToCelsius(300));

            Console.WriteLine(tempConvert.FahernheitToKelvin(400));

            Console.WriteLine(tempConvert.KelvinToFahrenheit(0));
        }
    }
}
