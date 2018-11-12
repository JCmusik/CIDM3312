using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitConvertWebApp.Models;
using ConverterLib.MassModels;
using ConverterLib.TempModels;
using ConverterLib.LengthModels;
using ConverterLib;

namespace UnitConvertWebApp.Controllers
{
    public class ConversionController : Controller
    {
        ITempConversions _tempConversion;
        ILengthConversions _lengthConversion;
        IMassConversions _massConversion;
        public ConversionController(ITempConversions tempConversion, ILengthConversions lengthConversion, IMassConversions massConversion)
        {
            _tempConversion = tempConversion;
            _lengthConversion = lengthConversion;
            _massConversion = massConversion;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TempConvert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TempConvert(string type, decimal numIn)
        {

            var result = _tempConversion.GetTemp(type, numIn);
            ViewData["result"] = result;

            return View();
        }

        [HttpGet]
        public IActionResult LengthConvert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LengthConvert(string type, decimal numIn)
        {

            var result = _lengthConversion.GetLength(type, numIn);
            ViewData["result"] = result;

            return View();
        }

        [HttpGet]
        public IActionResult MassConvert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MassConvert(string type, decimal numIn)
        {
            ViewData["length"] = "Result: ";

            var result = _massConversion.GetMass(type, numIn);
            ViewData["result"] = result;

            return View();
        }
    }
}