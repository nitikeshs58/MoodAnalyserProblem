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
        public string analyseMood()
        {
            try
            {
                if (message.Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
            }
            catch
            {
                return "happy";
            }
        }
    }
}
