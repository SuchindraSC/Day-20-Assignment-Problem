using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserAppWithCore;

namespace MoodAnalyserMSTesting
{
    [TestClass]
    class UC5TestClass
    {
        /// <summary>
        /// Test Case 5.1 Given MoodAnalyse Class Name Should Return MoodAnalyser Object.
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserFactoryUC5.CreateMoodAnalysisUsingParameterizedConstructor("MoodAnalyserAppWithCore.MoodAnalyser", "MoodAnalyser","HAPPY");
            expected.Equals(obj);
        }

        /// <summary>
        /// Test Case 5.2 Given Improper Class Name Should throw MoodAnalyssiException.
        /// </summary>
        [TestMethod]
        public void GivenImproperClassNameShouldThrowMoodAnalysisException_UsingParameterizedConstructor()
        {
            string expected = "Class Not Found";
            try
            {
                object moodAnalyseObject = MoodAnalyserFactoryUC5.CreateMoodAnalysisUsingParameterizedConstructor("MoodAnalyserAppWithCore.DemoClass", "MoodAnalysis","Class Not Found");

            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        /// <summary>
        /// Test Case 5.3 Given Improper Constructor Name Should throw MoodAnalyssiException.
        /// </summary>
        [TestMethod]
        public void GivenImproperConstructorNameShouldThrowMoodAnalysisException_UsingParameterizedConstructor()
        {
            string expected = "Constructor is Not Found";
            try
            {
                object moodAnalyseObject = MoodAnalyserFactoryUC5.CreateMoodAnalysisUsingParameterizedConstructor("MoodAnalyserAppWithCore.MoodAnalyser", "DemoConstructor","Construcot is Not Found");

            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
    }
}
