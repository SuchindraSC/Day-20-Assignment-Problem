using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserAppWithCore;


namespace MoodAnalyserMSTesting
{
    [TestClass]
    class UC7TestClass
    {
        /// <summary>
        /// Test Case 7.1 Given Happy Should Return Happy.
        /// </summary>
        [TestMethod]
        public void Given_HAPPYMessage_WithReflector_Should_ReturnHAPPY()
        {
            string result = MoodAnalyserFactoryUC7.SetField("HAPPY", "message");
            Assert.AreEqual("HAPPY", result);
        }

        /// <summary>
        /// Test Case 7.2 Given Improper FieldName Should Return MoodAnalysisException.
        /// </summary>
        [TestMethod]
        public void Given_ImproperFieldName_Should_Throw_MoodAnalysisException()
        {
            string expected = "Field is Not Found";
            try
            {
                string result = MoodAnalyserFactoryUC7.SetField("HAPPY", "DemoMessage");
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }

        /// <summary>
        /// Test Case 7.3 Given Null Message Should Return MoodAnalysisException.
        /// </summary>
        [TestMethod]
        public void Given_NULL_Message_WithReflector_Should_ReturnHAPPY()
        {
            try
            {
                string result = MoodAnalyserFactoryUC7.SetField(null, "message");
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Message should not be null", e.Message);
            }
        }
    }
}
