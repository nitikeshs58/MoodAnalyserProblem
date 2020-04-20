using System;
using System.Collections.Generic;
using System.Reflection;

namespace MoodAnalyserProblem
{
    public class MoodAnalyserFactory<GenericType>
    {

        /// <summary>
        /// Creating and Returning an object
        /// </summary>
        /// <param name="className"></param>
        /// <param name="constructor"></param>
        /// <returns></returns>
<<<<<<< HEAD
        public ConstructorInfo GetConstructor()
=======
        public object GetInstance(string className, ConstructorInfo constructor)
>>>>>>> UC5_ReflectionParameterConstructor
        {
            try
            {
                Type type = typeof(GenericType);
<<<<<<< HEAD
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
=======
                // given class not equals to type name throw exception
                if (className != type.Name)
                {
                    throw new MoodAnalyser.MoodAnalysisException(MoodAnalyser.MoodAnalysisException.Exceptiontype.NO_SUCH_CLASS_ERROR, "No such class found");
                }
                if (constructor != type.GetConstructors()[0])
                {
                    throw new MoodAnalyser.MoodAnalysisException(MoodAnalyser.MoodAnalysisException.Exceptiontype.NO_SUCH_METHOD_ERROR, "No such method found");
                }
                var obj = constructor.Invoke(new object[0]);
                Console.WriteLine("name obj " + obj);
                GenericType ReturnObject = Activator.CreateInstance<GenericType>();
                Console.WriteLine("name return object " + ReturnObject);
                return ReturnObject;
            }
            catch (MoodAnalyser.MoodAnalysisException e)
            {
                return e.Message;
            }
            catch (Exception Ex)
            {
                return Ex.Message;
>>>>>>> UC5_ReflectionParameterConstructor
            }
        }


        /// <summary>
        /// Creating and Returning an object
        /// </summary>
        /// <param name="className"></param>
        /// <param name="constructor"></param>
        /// <returns></returns>
<<<<<<< HEAD
        public object GetInstance(string className, ConstructorInfo constructor)
=======
        public object GetInstance(string className, ConstructorInfo constructor, string message)
>>>>>>> UC5_ReflectionParameterConstructor
        {
            try
            {
                Type type = typeof(GenericType);
                // given class not equals to type name throw exception
                if (className != "MoodAnalyzer")
                {
<<<<<<< HEAD
                    throw new MoodAnalysisException(MoodAnalysisException.Exceptiontype.NO_SUCH_CLASS_ERROR, "No such class found");
                }
                if (constructor != type.GetConstructors()[0])
=======
                    throw new MoodAnalyser.MoodAnalysisException(MoodAnalyser.MoodAnalysisException.Exceptiontype.NO_SUCH_CLASS_ERROR, "No such class found");
                }
                if (constructor != type.GetConstructors()[1])
>>>>>>> UC5_ReflectionParameterConstructor
                {
                    throw new MoodAnalysisException(MoodAnalysisException.Exceptiontype.NO_SUCH_METHOD_ERROR, "No such method found");
                }
<<<<<<< HEAD
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
=======
                object objectToReturn = Activator.CreateInstance(type, message);
                return objectToReturn;
            }
            catch (MoodAnalyser.MoodAnalysisException e)
            {
                return e.Message;
            }
            catch (Exception Ex)
            {
                return Ex.Message;
            }
        }

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
                throw new MoodAnalyser.MoodAnalysisException(MoodAnalyser.MoodAnalysisException.Exceptiontype.NO_SUCH_METHOD_ERROR, "No such method found");
            }
        }

        public ConstructorInfo ParameterisedConstructor(int numberOfParameter)
        {
            try
            {
                Type type = typeof(GenericType);
                ConstructorInfo[] constructor = type.GetConstructors();
                foreach (ConstructorInfo c in constructor)
                {
                    if (c.GetParameters().Length == numberOfParameter)
                    {
                        Console.WriteLine(c);
                        return c;
                    }
                }
                return constructor[0];
            }
            catch (Exception exception)
            {
                throw new MoodAnalyser.MoodAnalysisException(MoodAnalyser.MoodAnalysisException.Exceptiontype.NO_SUCH_CLASS_ERROR, "no such class found");
>>>>>>> UC5_ReflectionParameterConstructor
            }
        }
    }
}