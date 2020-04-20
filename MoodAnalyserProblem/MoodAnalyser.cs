using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        string message;

        // Default Constructor
        public MoodAnalyser()
        {
        }

        // Parameterised Constructor
        public MoodAnalyser(String message)
        {
            this.message = message;
        }

        /// <analyseMood>
        /// Method to return the mood analysis
        /// If user provide Invalid mood ,it return
        /// "happy"mood by using try catch block.
        /// </analyseMood>
        /// <param name="message"><. mood parameter >
        /// <returns></. Sad or Happy , type: string>
        public string AnalyseMood()
        {
            try
            {
                if (message == null)
                {
                    //Calling MoodAnalysisException(Exception type->enum, message)
                    throw new MoodAnalysisException(MoodAnalysisException.Exceptiontype.STRING_NULL, "null input passed");
                }
                if (message.Length == 0)
                {
                    //Calling MoodAnalysisException(Exception type->enum, message)
                    throw new MoodAnalysisException(MoodAnalysisException.Exceptiontype.INVALID_STRING, "String is empty");
                }

                if (message.Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        // customized(user) excetion extends(inheritance) Exception(inbulit library) 
        public class MoodAnalysisException:Exception
        {
            //Exceptiontype variable declared
            Exceptiontype type;

            //enum declarationn to give constant values
            public enum Exceptiontype
            {
                INVALID_STRING,
                STRING_NULL,
                OBJECT_CREATION_ERROR,
                NO_SUCH_METHOD_ERROR,
                NO_SUCH_CLASS_ERROR
            }
            /// <MoodAnalysisException>
            /// base: calling to super class (in this our super class is constructor)
            /// </MoodAnalysisException>
            public MoodAnalysisException(Exceptiontype type, string message):base(message)
            {
                this.type = type;                
            }
        }
    }
}
