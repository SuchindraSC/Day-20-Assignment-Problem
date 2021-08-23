using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyserAppWithCore;

namespace MoodAnalyserMSTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "HAPPY";
            string message = "I Am In A Happy Mood";

            MoodAnalyser moodAnalyse = new MoodAnalyser(message);

            string mood = moodAnalyse.AnalyseMethod();

            Assert.AreEqual(expected, mood);
        }

        [TestMethod]
        [DataRow("I Am in Happy Mood")]
        //[DataRow(null)]
        public void GivenHappyMoodShouldReturnHappy(string message)
        {
            string expected = "HAPPY";
            MoodAnalyser moodAnalyse = new MoodAnalyser(message);
            string mood = moodAnalyse.AnalyseMethod();
            Assert.AreEqual(expected, mood);
        }

        [TestMethod]
        public void Given_Empty_Mood_Should_Throw_MoodAnalysisException_Indicating_EmptyMethod()
        {
            try
            {
                string message = "";
                MoodAnalyser moodAnalyse = new MoodAnalyser(message);
                string mood = moodAnalyse.AnalyseMethod();
            }
            catch(MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood Should Not Be Empty", e.Message);
            }
        }

        [TestMethod]
        public void Given_Null_Mood_Should_Throw_MoodAnalysisException()
        {
            try
            {
                string message = null;
                MoodAnalyser moodAnalyse = new MoodAnalyser(message);
                string mood = moodAnalyse.AnalyseMethod();
            }
            catch(MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood Should Not Be Null", e.Message);
            }
        }
    }
}
