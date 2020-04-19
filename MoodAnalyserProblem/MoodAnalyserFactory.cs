using System;
using System.Collections.Generic;
using System.Reflection;

namespace MoodAnalyserProblem
{
    public class MoodAnalyserFactory<GenericType>
    {
        /// <summary>
        /// we will get class constructor from this method
        /// </summary>
        /// <returns></returns>
        public ConstructorInfo GetConstructor()
        {
            try
            {
                Type type = typeof(GenericType);
                ConstructorInfo[] constructor = type.GetConstructors();

                foreach (ConstructorInfo cInfo in constructor)
                {
                    if (cInfo.GetParameters().Length == 0)
                        return cInfo;
                }
                return constructor[0];

            }

            catch (Exception exception)
            {
                throw new MoodAnalysisException(MoodAnalysisException.Exceptiontype.NO_SUCH_METHOD_ERROR, "No such method found");
            }
        }

        /// <summary>
        /// Creating and Returning an object
        /// </summary>
        /// <param name="className"></param>
        /// <param name="constructor"></param>
        /// <returns></returns>
        public object GetInstance(string className, ConstructorInfo constructor)
        {
            try
            {
                Type type = typeof(GenericType);
                // given class not equals to type name throw exception
                if (className != type.Name)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.Exceptiontype.NO_SUCH_CLASS_ERROR, "No such class found");
                }
                if (constructor != type.GetConstructors()[0])
                {
                    throw new MoodAnalysisException(MoodAnalysisException.Exceptiontype.NO_SUCH_METHOD_ERROR, "No such method found");
                }
                GenericType objectToReturn = Activator.CreateInstance<GenericType>();
                return objectToReturn;
            }
            catch(MoodAnalysisException e)
            {
                return e.Message;
            }
            catch(Exception Ex)
            {
                return Ex.Message;
            }
        }
    }
}