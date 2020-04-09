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
        /// </analyseMood>
        /// <param name="message"><. mood parameter >
        /// <returns></. Sad or Happy , type: string>
        public string analyseMood()
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
    }
}
