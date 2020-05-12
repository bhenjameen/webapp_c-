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

            int firstRoot = Convert.ToInt32 (Math.Sqrt (numeroOne));
            int secondRoot = Convert.ToInt32 (Math.Sqrt (numeroTwo));

            string result = "";

            if (firstRoot > secondRoot) {
                result = ("The number " + numeroOne + " with Square root " + firstRoot + " has a higher square root than the number " + numeroTwo + " with square root " + secondRoot);
            } else if (secondRoot > firstRoot) {
                result = ("The number " + numeroTwo + " with Square root " + secondRoot + " has a higher square root than the number " + numeroOne + " with square root " + firstRoot);
            } else if (firstRoot == secondRoot) {
                result = ("The number " + numeroTwo + " with Square root " + secondRoot + " has the same square root as the number " + numeroOne + " with square root " + firstRoot + ". \n\nPlease enter another set of values. Try inputting different numbers.");
            }
            //} else if (int.TryParse (secondNumber, out numeroTwo)) {
            //    int firstRoot = Convert.ToInt32 (Math.Sqrt (numeroOne));
            //    int secondRoot = Convert.ToInt32 (Math.Sqrt (numeroTwo));

            //    if (numeroTwo > numeroOne) {
            //        result = ("The number " + numeroTwo + " with Square root " + secondRoot + " has a higher square root than the number " + numeroOne + " with square root " + firstRoot);
            //        //} else if (numeroTwo > numeroOne) {
            //        //    result = ("The number " + numeroTwo + " with Square root " + secondRoot + "has a higher square root than the number " + numeroOne + " with square root " + firstRoot);
            //    }
            //} else {
            //    result = ("\nThat is not a number. \nPlease check your input and ensure it is a number");
            //}

            ViewBag.Result = result;
            return View ();
        }
    }
}