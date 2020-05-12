using System;
using Microsoft.AspNetCore.Mvc;

namespace SqrRootWebApp.Controllers {
    public class CalcController : Controller {

        [HttpGet]
        public ActionResult SqrRoot () {
            return View ();
        }

        [HttpPost]
        public ActionResult SqrRoot (string firstNumber, string secondNumber) {
            int numeroOne = int.Parse (firstNumber);
            int numeroTwo = int.Parse (secondNumber);
            int result = Convert.ToInt32 (Math.Sqrt (numeroOne) + Math.Sqrt (numeroTwo));

            ViewBag.Result = result;
            return View ();
        }
    }
}