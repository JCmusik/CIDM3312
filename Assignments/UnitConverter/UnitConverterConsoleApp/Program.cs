using System;
using ConverterLib.TempModels;
using ConverterLib.MassModels;
using ConverterLib.LengthModels;

namespace UnitConverterConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Temp Conversions

            Console.WriteLine("---------------Temperature Conversions----------------");

            // Instantiate new objects that implement ITempConversions
            ITempConversions cToF = new CelsiusToFahrenheit();
            ITempConversions fToC = new FahrenheitToCelsius();
            ITempConversions cToK = new CelsiusToKelvin();
            ITempConversions kToC = new KelvinToCelsius();
            ITempConversions fToK = new FahrenheitToKelvin();
            ITempConversions kToF = new KelvinToFahrenheit();

            // Write to the Console the return of the GetTemp method
            Console.WriteLine(Math.Round(cToF.GetTemp(15), 2));
            Console.WriteLine(Math.Round(fToC.GetTemp(15), 2));
            Console.WriteLine(Math.Round(cToK.GetTemp(15), 2));
            Console.WriteLine(Math.Round(kToC.GetTemp(15), 2));
            Console.WriteLine(Math.Round(fToK.GetTemp(15), 2));
            Console.WriteLine(Math.Round(kToF.GetTemp(15), 2));

            #endregion


            #region Mass Conversions

            Console.WriteLine("\n--------------Mass Conversions----------------------");
            IMassConversions gToK = new GramToKilogram();
            IMassConversions kToG = new KilogramToGram();
            IMassConversions gToO = new GramToOunce();
            IMassConversions oToG = new OunceToGram();
            IMassConversions gToP = new GramToPound();
            IMassConversions pToG = new PoundToGram();
            IMassConversions pToO = new PoundToOunce();
            IMassConversions oToP = new OunceToPounds();
            IMassConversions kToO = new KilogramToOunce();
            IMassConversions oToK = new OunceToKilogram();
            IMassConversions pToK = new PoundToKilogram();
            IMassConversions kToP = new KilogramToPound();

            Console.WriteLine(Math.Round(gToK.GetMass(50), 2));
            Console.WriteLine(Math.Round(kToG.GetMass(50), 2));
            Console.WriteLine(Math.Round(gToO.GetMass(50), 2));
            Console.WriteLine(Math.Round(oToG.GetMass(50), 2));
            Console.WriteLine(Math.Round(gToP.GetMass(50), 2));
            Console.WriteLine(Math.Round(pToG.GetMass(50), 2));
            Console.WriteLine(Math.Round(pToO.GetMass(50), 2));
            Console.WriteLine(Math.Round(oToP.GetMass(50), 2));
            Console.WriteLine(Math.Round(kToO.GetMass(50), 2));
            Console.WriteLine(Math.Round(oToK.GetMass(50), 2));
            Console.WriteLine(Math.Round(pToK.GetMass(50), 2));
            Console.WriteLine(Math.Round(kToP.GetMass(50), 2));



            #endregion


            #region Length Conversions

            Console.WriteLine("\n--------------Length Conversions----------------------");

            ILengthConversions fToM = new FeetToMeters();
            ILengthConversions mToF = new MetersToFeet();
            ILengthConversions fToY = new FeetToYards();
            ILengthConversions yToF = new YardsToFeet();
            ILengthConversions yToM = new YardsToMeters();
            ILengthConversions mToY = new MetersToYards();

            Console.WriteLine(Math.Round(fToM.GetLength(25), 2));
            Console.WriteLine(Math.Round(mToF.GetLength(25), 2));
            Console.WriteLine(Math.Round(fToY.GetLength(25), 2));
            Console.WriteLine(Math.Round(yToF.GetLength(25), 2));
            Console.WriteLine(Math.Round(yToM.GetLength(25), 2));
            Console.WriteLine(Math.Round(mToY.GetLength(25), 2));

            #endregion

            Console.WriteLine();
        }
    }
}
