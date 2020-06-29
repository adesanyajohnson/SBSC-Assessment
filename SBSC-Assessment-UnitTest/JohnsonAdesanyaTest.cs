using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SBSC_Assessment;
using System.Collections.Generic;

namespace SBSC_Assessment_UnitTest
{
    [TestClass]
    public class JohnsonAdesanyaTest
    {
        [TestMethod]
        public void Question1TestMethod()
        {
            bool expected = true;
            JohnsonAdesanya assessmentClass = new JohnsonAdesanya();
            bool result = assessmentClass.Question1("3-4-5-6-7");
            Assert.AreEqual(expected, result, "Question1 Method not implemented correctly");
        }

        [TestMethod]
        public void Question2TestMethod()
        {
            int expected = 7;
            List<int> inputList = new List<int> {1, 4, 6, 9 };
            JohnsonAdesanya assessmentClass = new JohnsonAdesanya();
            int result = assessmentClass.Question2(inputList);
            Assert.AreEqual(expected, result, string.Format("Question2 Method returned {0} instead of 7", result.ToString()));
        }

        [TestMethod]
        public void Question3TestMethod()
        {
        }
    }
}
