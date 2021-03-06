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

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(decimal num1, decimal num2)
        {
            ViewData["result"] = MathRoutines.Add(num1, num2);

            return View();
        }

        [HttpGet]
        public IActionResult Subtract()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Subtract(decimal num1, decimal num2)
        {
            ViewData["result"] = MathRoutines.Subtract(num1, num2);

            return View();
        }

        [HttpGet]
        public IActionResult Multiply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Multiply(decimal num1, decimal num2)
        {
            ViewData["result"] = MathRoutines.Multiply(num1, num2);

            return View();
        }

        [HttpGet]
        public IActionResult Divide()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Divide(decimal num1, decimal num2)
        {

            if (num2 != 0)
            {
                ViewData["result"] = MathRoutines.Divide(num1, num2);

                return View();
            }
            else
            {
                ViewData["result"] = "Please Enter a number other than 0 for Number 2";
                return View();
            }

        }

        [HttpGet]
        public IActionResult Power()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Power(double num1, double num2)
        {
            ViewData["result"] = MathRoutines.Power(num1, num2);

            return View();
        }

        [HttpGet]
        public IActionResult Ceiling()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ceiling(decimal num1)
        {
            ViewData["result"] = MathRoutines.Ceiling(num1);
            return View();
        }

        [HttpGet]
        public IActionResult Floor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Floor(decimal num1)
        {
            ViewData["result"] = MathRoutines.Floor(num1);
            return View();
        }

    }
}
