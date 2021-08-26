using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace MoodAnalyserAppWithCore
{
    public class MoodAnalyserFactoryUC7
    {
        public static string SetField(string message, string fieldName)
        {
            try
            {
                MoodAnalyser moodAnalyse = new MoodAnalyser(message);
                Type type = typeof(MoodAnalyser);
                FieldInfo field = type.GetField(fieldName, BindingFlags.Public | BindingFlags.Instance);
                if (message == null)
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_FIELD, "Message should not be null");
                }
                field.SetValue(moodAnalyse, message);
                return moodAnalyse.message;
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_FIELD, "Field is Not Found");
            }
        }
    }
}
