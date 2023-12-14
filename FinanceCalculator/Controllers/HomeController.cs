using System;
using Microsoft.AspNetCore.Mvc;
using FinanceCalculator.Models;

namespace FinanceCalculator.Controllers{
    public class HomeController : Controller {
        
        [Route("/")]
        public ActionResult Home()
        {
            return View();
        }

        [Route("/finalAmount")]
        public ActionResult FinalAmount(string amount, string rate, string term)
        {

                double finalAmount = double.Parse(amount);
                double interestRate = double.Parse(rate);
                int termOfInvestment = int.Parse(term);

                CompoundInterest newInvestment = new CompoundInterest();
                newInvestment.Term = termOfInvestment;
                newInvestment.Rate = interestRate;
                newInvestment.Amount = finalAmount;

                newInvestment.CalculateFinalAmount(finalAmount,interestRate,termOfInvestment);

                return View(newInvestment);
        }
    }
}