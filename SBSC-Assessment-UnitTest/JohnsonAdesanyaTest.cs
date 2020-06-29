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
            Assert.AreEqual(expected, result, 
                string.Format("Question1 TestMethod returned {0} instead of {1}", result.ToString(), expected.ToString()));
        }

        [TestMethod]
        public void Question2TestMethod()
        {
            int expected = 7;
            List<int> inputList = new List<int> {1, 4, 6, 9 };
            JohnsonAdesanya assessmentClass = new JohnsonAdesanya();
            int result = assessmentClass.Question2(inputList);
            Assert.AreEqual(expected, result,
                string.Format("Question2 TestMethod returned {0} instead of {1}", result.ToString(), expected.ToString()));
        }

        [TestMethod]
        public void Question3TestMethod()
        {
            string expected = "o1c3u1r2e2n1";
            List<int> inputList = new List<int> { 1, 4, 6, 9 };
            JohnsonAdesanya assessmentClass = new JohnsonAdesanya();
            string result = assessmentClass.Question3("occurrence");
            Assert.AreEqual(expected, result, string.Format("Question3 TestMethod returned {0} instead of {1}", result, expected));
        }
    }
}
