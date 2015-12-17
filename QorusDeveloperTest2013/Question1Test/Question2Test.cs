using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Questions;

namespace Question1Test
{
    [TestClass]
    public class Question2Test
    {
        [TestMethod]
        public void SwopCharacters_abcdef123_Expect_cbafed321()
        {
            var answer = Question2.SwopCharacters("abcdef123");
            Assert.AreEqual("cbafed321", answer);
        }

        [TestMethod]
        public void SwopCharacters_Qorus1_Expect_roQ1su()
        {
            var answer = Question2.SwopCharacters("Qorus1");
            Assert.AreEqual("roQ1su", answer);
        }
    }
}
