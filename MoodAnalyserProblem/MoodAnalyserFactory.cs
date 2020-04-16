using System;
using System.Collections.Generic;
using System.Reflection;

namespace MoodAnalyserProblem
{
    public class MoodAnalyserFactory
    {
        /// <summary>
        /// we will get class constructor from this method
        /// </summary>
        /// <returns></returns>
        public ConstructorInfo[] GetConstructor()
        {
            try
            {
                Type type = typeof(MoodAnalyser);
                ConstructorInfo[] constructor = type.GetConstructors();
                return constructor;
            }
            catch(Exception exception)
            {
                throw new MoodAnalyser.MoodAnalysisException(MoodAnalyser.MoodAnalysisException.Exceptiontype.NO_SUCH_CLASS_ERROR, "Class not found");
            }
        }

        /// <summary>
        /// Creating and Returning an object
        /// </summary>
        /// <param name="className"></param>
        /// <param name="constructor"></param>
        /// <returns></returns>
        public object GetInstance(string className, string constructor)
        {
            try
            {
                Type type = typeof(MoodAnalyser);
                // given class not equals to type name throw exception
                if (className != type.Name)
                {
                    throw new MoodAnalyser.MoodAnalysisException(MoodAnalyser.MoodAnalysisException.Exceptiontype.NO_SUCH_CLASS_ERROR, "Enter valid class");
                }
                if(constructor == "MoodAnalysis")
                {
                    throw new MoodAnalyser.MoodAnalysisException(MoodAnalyser.MoodAnalysisException.Exceptiontype.NO_SUCH_METHOD_ERROR, "No such method found");
                }
                object objectToReturn = Activator.CreateInstance(type);
                return objectToReturn;                             

            }
            catch(Exception exception)
            {
                throw new MoodAnalyser.MoodAnalysisException(MoodAnalyser.MoodAnalysisException.Exceptiontype.OBJECT_CREATION_ERROR, "Error in object creation");
            }
        }
    }
}