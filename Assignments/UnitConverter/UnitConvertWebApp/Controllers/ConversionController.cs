using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitConvertWebApp.Models;
using ConverterLib;
using DataAccess;

namespace UnitConvertWebApp.Controllers
{
    public class ConversionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TempConvert(decimal numIn)
        {
            ITempConversions tempConversions = new TempConversions();

            ViewData["NumInput"] = numIn;
            ViewData["CtoF"] = Math.Round(tempConversions.CelsiusToFahrenheit(numIn), 2);
            ViewData["FtoC"] = Math.Round(tempConversions.FahrenheitToCelsius(numIn), 2);
            ViewData["CtoK"] = Math.Round(tempConversions.CelsiusToKelvin(numIn), 2);
            ViewData["KtoC"] = Math.Round(tempConversions.KelvinToCelsius(numIn), 2);
            ViewData["FtoK"] = Math.Round(tempConversions.FahernheitToKelvin(numIn), 2);
            ViewData["KtoF"] = Math.Round(tempConversions.KelvinToFahrenheit(numIn), 2);
            return View();
        }

        public IActionResult LengthConvert(decimal numIn)
        {
            ILengthConversions lengthConversions = new LengthConversions();

            ViewData["NumInput"] = numIn;
            ViewData["MtoF"] = Math.Round(lengthConversions.MetersToFeet(numIn), 2);
            ViewData["FtoM"] = Math.Round(lengthConversions.FeetToMeters(numIn), 2);
            ViewData["MtoY"] = Math.Round(lengthConversions.MetersToYards(numIn), 2);
            ViewData["YtoM"] = Math.Round(lengthConversions.YardsToMeters(numIn), 2);
            ViewData["FtoY"] = Math.Round(lengthConversions.FeetToYards(numIn), 2);
            ViewData["YtoF"] = Math.Round(lengthConversions.YardsToFeet(numIn), 2);

            return View();
        }

        public IActionResult MassConvert(decimal numIn)
        {
            IMassConversions massConversion = new MassConversions();
            ViewData["NumInput"] = numIn;
            ViewData["OtoL"] = Math.Round(massConversion.OunceToPound(numIn), 2);
            ViewData["LtoO"] = Math.Round(massConversion.PoundToOunce(numIn), 2);
            ViewData["OtoG"] = Math.Round(massConversion.OunceToGram(numIn), 2);
            ViewData["GtoO"] = Math.Round(massConversion.GramToOunce(numIn), 2);
            ViewData["OtoK"] = Math.Round(massConversion.OunceToKilogram(numIn), 2);
            ViewData["KtoO"] = Math.Round(massConversion.KilogramToOunce(numIn), 2);
            ViewData["LtoG"] = Math.Round(massConversion.PoundToGram(numIn), 2);
            ViewData["GtoL"] = Math.Round(massConversion.GramToPound(numIn), 2);
            ViewData["LtoK"] = Math.Round(massConversion.PoundToKilogram(numIn), 2);
            ViewData["KtoL"] = Math.Round(massConversion.KilogramToPound(numIn), 2);
            ViewData["GtoK"] = Math.Round(massConversion.GramToKilogram(numIn), 2);
            ViewData["KtoG"] = Math.Round(massConversion.KilogramToGram(numIn), 2);

            return View();
        }
    }
}