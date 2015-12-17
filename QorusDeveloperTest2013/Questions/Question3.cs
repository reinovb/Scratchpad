using System;

namespace Questions
{
    public static class Question3
    {
        public const string Title = "Find and fix the bugs (15 min)";

        public static decimal CalculateLoan(double months, double interestRate, decimal purchasePrice, decimal downPayment)
        {
            var loanTerms = new LoanTerms(months, interestRate);   //BUG HERE, REVERSED PARAMETERS
            var paymentCalculator = new LoanPaymentCalculator
            {
                DownPayment = downPayment,
                PurchasePrice = purchasePrice,
                Terms = loanTerms
            };

            return paymentCalculator.CalculatePayment();
        }
    }
    
    public class LoanPaymentCalculator
    {
        private const int MonthsPerYear = 12;

        public LoanTerms Terms { get; set; }

        public decimal PurchasePrice { get; set; }

        public decimal DownPayment { get; set; }

        public decimal LoanAmount
        {
            get { return (PurchasePrice - DownPayment); }
        }

        public decimal CalculatePayment()
        {
            decimal payment = 0;

            if (Terms.Months == 0)   //BUG HERE
            {
                return Math.Round(payment, 2);
            }

            if (Terms.InterestRate != 0)
            {
                double rate = ((Terms.InterestRate / MonthsPerYear) / 100);
                decimal factor = (decimal) (rate + (rate/(Math.Pow((rate + 1), Terms.Months) - 1)));
                payment = (LoanAmount*factor);
            }
            else
            {
                payment = (LoanAmount/(decimal) Terms.Months);
            }

            return Math.Round(payment, 2);
        }
    }

    public class LoanTerms
    {
        public double Months;
        public double InterestRate;

        public LoanTerms(double months, double interestRate)
        {
            Months = months;
            InterestRate = interestRate;
        }
    }
}
