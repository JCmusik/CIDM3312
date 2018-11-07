using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebCalculator.Models;
using MathLibrary;

namespace MyWebCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(decimal num1, decimal num2)
        {
            ViewData["num1"] = Convert.ToString(num1);
            ViewData["num2"] = Convert.ToString(num2);

            ViewData["result"] = MathRoutines.Add(num1, num2);

            return View();
        }
        public IActionResult Subtract(decimal num1, decimal num2)
        {
            ViewData["num1"] = Convert.ToString(num1);
            ViewData["num2"] = Convert.ToString(num2);
            ViewData["result"] = MathRoutines.Subtract(num1, num2);

            return View();
        }

        public IActionResult Multiply(decimal num1, decimal num2)
        {
            ViewData["num1"] = Convert.ToString(num1);
            ViewData["num2"] = Convert.ToString(num2);
            ViewData["result"] = MathRoutines.Multiply(num1, num2);

            return View();
        }

        public IActionResult Divide(decimal num1, decimal num2)
        {
            ViewData["num1"] = Convert.ToString(num1);
            ViewData["num2"] = Convert.ToString(num2);
            ViewData["result"] = MathRoutines.Divide(num1, num2);

            return View();
        }

        public IActionResult Power(double num1, double num2)
        {
            ViewData["num1"] = Convert.ToString(num1);
            ViewData["num2"] = Convert.ToString(num2);
            ViewData["result"] = MathRoutines.Power(num1, num2);

            return View();
        }

        public IActionResult Ceiling(decimal num1)
        {
            ViewData["num1"] = Convert.ToString(num1);
            ViewData["result"] = MathRoutines.Ceiling(num1);
            return View();
        }

        public IActionResult Floor(decimal num1)
        {
            ViewData["num1"] = Convert.ToString(num1);
            ViewData["result"] = MathRoutines.Floor(num1);
            return View();
        }

    }
}
