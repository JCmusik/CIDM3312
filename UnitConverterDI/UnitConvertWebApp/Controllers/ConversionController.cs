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
        IConverter _converter;
        public ConversionController(IConverter converter)
        {
            _converter = converter;
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

            var result = _converter.GetConversion(type, numIn);
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

            var result = _converter.GetConversion(type, numIn);
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
            var result = _converter.GetConversion(type, numIn);
            ViewData["result"] = result;

            return View();
        }
    }
}