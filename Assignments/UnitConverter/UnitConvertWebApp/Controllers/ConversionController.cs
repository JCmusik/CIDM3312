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
        private IDataAccess dataAccess;
        public ConversionController(IDataAccess db)
        {
            dataAccess = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TempConvert()
        {
            return View();
        }

        public IActionResult LengthConvert()
        {
            return View();
        }

        public IActionResult MassConvert()
        {
            return View();
        }
    }
}