using System;
using ConverterLib;

namespace UnitConverterConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Temperature Conversions
            Console.WriteLine("---------------Temperature Conversions----------------");

            ITempConversions tempConvert = new TempConversions();

            Console.WriteLine(tempConvert.CelsiusToFahrenheit(15));

            Console.WriteLine(tempConvert.FahrenheitToCelsius(59));

            Console.WriteLine(tempConvert.CelsiusToKelvin(15));

            Console.WriteLine(tempConvert.KelvinToCelsius(300));

            Console.WriteLine(tempConvert.FahernheitToKelvin(400));

            Console.WriteLine(tempConvert.KelvinToFahrenheit(0));

            // Mass Conversions
            Console.WriteLine("\n--------------Mass Conversions----------------------");

            IMassConversions massConvert = new MassConversions();

            Console.WriteLine(massConvert.OunceToPound(16));

            Console.WriteLine(massConvert.PoundToOunce(1));

            Console.WriteLine(massConvert.OunceToGram(16));

            Console.WriteLine(massConvert.GramToOunce(100));

            Console.WriteLine(massConvert.OunceToKilogram(100));

            Console.WriteLine(massConvert.KilogramToOunce(1000));

            Console.WriteLine(massConvert.PoundToGram(10));

            Console.WriteLine(massConvert.GramToPound(200));

            Console.WriteLine(massConvert.PoundToKilogram(10));

            Console.WriteLine(massConvert.KilogramToPound(2000));

            Console.WriteLine(massConvert.GramToKilogram(1000));

            Console.WriteLine(massConvert.KilogramToGram(1000));

            // Length Conversions
            Console.WriteLine("\n--------------Length Conversions----------------------");

            ILengthConversions lengthConvert = new LengthConversions();

            Console.WriteLine(lengthConvert.MetersToFeet(6));

            Console.WriteLine(lengthConvert.FeetToMeters(6));

            Console.WriteLine(lengthConvert.MetersToYards(10));

            Console.WriteLine(lengthConvert.YardsToMeters(15));

            Console.WriteLine(lengthConvert.FeetToYards(6));

            Console.WriteLine(lengthConvert.YardsToFeet(25));

        }
    }
}
