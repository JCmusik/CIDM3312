using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebCalculator.Models;

namespace MyWebCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(double num1, double num2)
        {
            ViewData["num1"] = Convert.ToString(num1);
            ViewData["num2"] = Convert.ToString(num2);
            ViewData["result"] = num1 + num2;

            return View();
        }
        public IActionResult Subtract(double num1, double num2)
        {
            ViewData["num1"] = Convert.ToString(num1);
            ViewData["num2"] = Convert.ToString(num2);
            ViewData["result"] = num1 - num2;

            return View();
        }

        public IActionResult Multiply(double num1, double num2)
        {
            ViewData["num1"] = Convert.ToString(num1);
            ViewData["num2"] = Convert.ToString(num2);
            ViewData["result"] = num1 * num2;

            return View();
        }

        public IActionResult Divide(double num1, double num2)
        {
            ViewData["num1"] = Convert.ToString(num1);
            ViewData["num2"] = Convert.ToString(num2);
            ViewData["result"] = num1 / num2;

            return View();
        }

        public IActionResult Power(double num1, double num2)
        {
            ViewData["num1"] = Convert.ToString(num1);
            ViewData["num2"] = Convert.ToString(num2);
            ViewData["result"] = Math.Pow(num1, num2);

            return View();
        }

        public IActionResult Ceiling(double num1)
        {
            ViewData["num1"] = Convert.ToString(num1);
            ViewData["result"] = Math.Ceiling(num1);
            return View();
        }

        public IActionResult Floor(double num1)
        {
            ViewData["num1"] = Convert.ToString(num1);
            ViewData["result"] = Math.Floor(num1);
            return View();
        }

    }
}
