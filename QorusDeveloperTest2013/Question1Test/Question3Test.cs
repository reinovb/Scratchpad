using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Question1Test
{
    [TestClass]
    public class Question3Test
    {
        [TestMethod]
        public void CalculateLoan_GivenPeriodOf60Months_InterestOf6_PriceOf50000_DownPaymentOf10000_ExpectRepaymentOf_773point31()
        {
            decimal result = Questions.Question3.CalculateLoan(60, 6, 50000, 10000);
            Assert.AreEqual((decimal)773.31, result);
        }

        [TestMethod]
        public void CalculateLoan_GivenPeriodOf120Months_InterestOf9_PriceOf75000_DownPaymentOf5000_ExpectRepaymentOf_886point73()
        {
            decimal result = Questions.Question3.CalculateLoan(120, 9, 75000, 5000);
            Assert.AreEqual((decimal)886.73, result);
        }
    }
}
