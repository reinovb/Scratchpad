using System;
using System.Web.Mvc;

namespace Qorus_Developer_Test.Controllers
{
    public class QuestionsController : Controller
    {
        public ActionResult Question1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Answer1(string inputValue)
        {
            Int64 result = Questions.Question1.SumOddNumbers(inputValue);
            ViewBag.ResultMessage = result;
            return PartialView("Answer1");
        }

        public ActionResult Question2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Answer2(string inputValue)
        {
            string result = Questions.Question2.SwopCharacters(inputValue);
            ViewBag.ResultMessage = result;
            return PartialView("Answer2");
        }

        public ActionResult Question3()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Answer3(double months, double interestRate, decimal purchasePrice, decimal downPayment)
        {
            decimal result = Questions.Question3.CalculateLoan(months, interestRate, purchasePrice, downPayment);
            ViewBag.ResultMessage = result;
            return PartialView("Answer3");
        }

        public ActionResult Question4()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Answer4()
        {
            string result = Questions.Question4.GroupByCountry();
            ViewBag.ResultMessage = result;
            return PartialView("Answer4");
        }

        public ActionResult Question5()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Answer5()
        {
            string result = Questions.Question4.GroupByCountry();
            ViewBag.ResultMessage = result;
            return PartialView("Answer5");
        }
    }
}