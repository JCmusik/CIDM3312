using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MidTerm2.Models;
using MathLibrary;

namespace MidTerm2.Controllers
{
    public class MathController : Controller
    {

        [HttpGet]
        public IActionResult DoCalculation()
        {
            return View();
        }

        // Will have an ActionMethod called "ShowCalculationResults" which responds to the HttpPost you would return form data binding the model to the form

        [HttpPost]
        public IActionResult ShowCalculationResults(MathOperation operation)
        {
            switch (operation.Operator)
            {
                case "+":
                    operation.Result = MathLibrary.MathRoutines.Add(operation.LeftOperand, operation.RightOperand);
                    break;
                case "-":
                    operation.Result = MathLibrary.MathRoutines.Subtract(operation.LeftOperand, operation.RightOperand);
                    break;
                case "*":
                    operation.Result = MathLibrary.MathRoutines.Multiply(operation.LeftOperand, operation.RightOperand);
                    break;
                case "/":
                    operation.Result = MathLibrary.MathRoutines.Divide(operation.LeftOperand, operation.RightOperand);
                    break;
                default:
                    break;
            }

            return View(operation);
        }
    }
}
