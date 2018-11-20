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
        #region Methods

        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult NewIndex(ConverterViewModel model)
        {
            // do calculation here
            model.ConvertedValue = model.ValueToConvert * model.ValueToConvert;

            return View(model);
        }

        [HttpGet]
        public IActionResult TempConvert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TempConvert(string type, decimal numIn)
        {
            ViewData["Type"] = type;
            ViewData["Anything"] = numIn;
            ITempConversions tempConvert = new TempConverter();

            var result = tempConvert.GetTemp(type, numIn);
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
            ILengthConversions lengthConvert = new LengthConverter();

            var result = lengthConvert.GetLength(type, numIn);
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
            IMassConversions massConvert = new MassConverter();

            var result = massConvert.GetMass(type, numIn);
            ViewData["result"] = result;

            return View();
        }
        #endregion
    }
}