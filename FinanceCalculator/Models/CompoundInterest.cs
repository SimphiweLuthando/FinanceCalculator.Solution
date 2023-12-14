using System;

namespace FinanceCalculator.Models
{
    public class CompoundInterest
    {
        public double Amount {get; set;}
        public double Rate {get; set;}
        public double FinalAmount {get;set;}
        public int Term {get; set;}

        public void CalculateFinalAmount(double amount, double rate, int term){
            Amount = amount;
            Rate = rate;
            Term = term;

            FinalAmount = Amount * Math.Pow((1 + (Rate / 100)), Term);
            
            
        }
    
    }
}