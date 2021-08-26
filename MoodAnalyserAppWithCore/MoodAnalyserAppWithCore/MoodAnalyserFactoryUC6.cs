using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace MoodAnalyserAppWithCore
{
    public class MoodAnalyserFactoryUC6
    {
        public static string InvokeAnalyseMood(string message, string methodName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyserAppWithCore.MoodAnalyser");
                object moodAnalyseObject = MoodAnalyserFactoryUC5.CreateMoodAnalysisUsingParameterizedConstructor("MoodAnalyserAppWithCore.MoodAnalyser", "MoodAnalyser", message);
                MethodInfo analyseMoodInfo = type.GetMethod(methodName);
                object mood = analyseMoodInfo.Invoke(moodAnalyseObject, null);
                return mood.ToString();
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_METHOD, "Method is Not Found");
            }
        }
    }
}
