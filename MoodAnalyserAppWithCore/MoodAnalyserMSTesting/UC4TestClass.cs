using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using MoodAnalyserAppWithCore;

namespace MoodAnalyserMSTesting
{
    [TestClass]
    class UC4TestClass
    {

        /// <summary>
        /// Test Case 4.1 Given MoodAnalyse Class Name Should Return MoodAnalyser Object.
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserFactoryUC4.CreateMoodAnalysis("MoodAnalyserAppWithCore.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }

        /// <summary>
        /// Test Case 4.2 Given Improper Class Name Should throw MoodAnalyssiException.
        /// </summary>
        [TestMethod]
        public void GivenImproperClassNameShouldThrowMoodAnalysisException()
        {
            string expected = "Class Not Found";
            try
            {
                object moodAnalyseObject = MoodAnalyserFactoryUC4.CreateMoodAnalysis("MoodAnalyserAppWithCore.DemoClass", "DemoClass");

            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        // <summary>
        /// Test Case 4.3 Given Improper Constructor should throw MoodAnalysisException.
        /// </summary>
        [TestMethod]
        public void GivenImproperConstructorShouldThrowMoodAnalysisException()
        {

            string expected = "Constructor is Not Found";
            try
            {
                object moodAnalyseObject = MoodAnalyserFactoryUC4.CreateMoodAnalysis("DemoClass", "MoodAnalyse");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
    }
}
