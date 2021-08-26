using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserAppWithCore;

namespace MoodAnalyserMSTesting
{
    class UC6TestClass
    {
        // <summary>
        /// Test Case 6.1 Given Happy Should Return Happy.
        /// </summary>
        [TestMethod]
        public void GivenHappyMoodShouldReturnHappy()
        {
            string expected = "HAPPY";
            string mood = MoodAnalyserFactoryUC6.InvokeAnalyseMood("Happy", "AnalyseMethod");
            Assert.AreEqual(expected, mood);
        }

        /// <summary>
        /// Test Case 6.2 Given Happy Should Return Happy.
        /// </summary>
        [TestMethod]
        public void Given_ImproperMethodName_Should_Throw_MoodAnalysisException()
        {
            string expected = "Method is Not Found";
            try
            {
                string mood = MoodAnalyserFactoryUC6.InvokeAnalyseMood("Happy", "DemoMethod");
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
    }
}
