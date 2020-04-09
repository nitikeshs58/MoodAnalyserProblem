using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        string message;

        /// <analyseMood>
        /// Method to return the mood analysis
        /// </analyseMood>
        /// <param name="message"><. mood parameter >
        /// <returns></. Sad or Happy , type: string>
        public string analyseMood(string message)
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
