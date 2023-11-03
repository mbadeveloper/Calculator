using Calculator.Modules;
using Calculator.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly List<Operation> Operations;

        public CalculatorController(ICalculationService calculationService)
        {
            Operations = new List<Operation>();
        }
        public IActionResult Calcualte()
        {


            return View();
        }

        public IActionResult AddNumber(int value)
        {

        }
    }
}
