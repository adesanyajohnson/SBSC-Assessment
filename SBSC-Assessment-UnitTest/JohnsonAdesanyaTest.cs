using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SBSC_Assessment;

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
        }

        [TestMethod]
        public void Question3TestMethod()
        {
        }
    }
}
