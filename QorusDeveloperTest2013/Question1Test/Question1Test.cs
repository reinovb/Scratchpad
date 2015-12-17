using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Questions;

namespace Question1Test
{
    [TestClass]
    public class Question1Test
    {
        [TestMethod]
        public void SumOddNumbers_PassIn7_ExpectAnswerOf16()
        {
            var answer = Question1.SumOddNumbers("7");
            Assert.AreEqual(16, answer);
        }

        [TestMethod]
        public void SumOddNumbers_PassIn4_ExpectAnswerOf4()
        {
            var answer = Question1.SumOddNumbers("4");
            Assert.AreEqual(answer, 4);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void SumOddNumbers_PassInInvalidString_ExpectHandledException()
        {
            var answer = Question1.SumOddNumbers("FOUR");
            
        }


    }
}
