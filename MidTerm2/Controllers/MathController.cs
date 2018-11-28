using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MidTerm2.Models;

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
            var mathop = new MathOperation();
            switch (operation.Operator)
            {
                case "Add":
                    operation.Result = operation.LeftOperand + operation.RightOperand;
                    break;
                case "Mul":
                    operation.Result = operation.LeftOperand * operation.RightOperand;
                    break;
                default:
                    break;
            }
            return View(operation);
        }
    }
}
