using NUnit.Framework;
using MoodAnalyserProblem;

namespace Tests
{
    public class Tests
    {
        MoodAnalyser mood = null;


       [SetUp]
        public void Setup()
        {
        }

        /// <checkForSad>
        /// Calling parameteried constructor
        /// Calling No parameter analyseMood method
        /// checking return mood is "sad" are not
        /// if return mood "sad" then Test passed.
        /// </checkForSad>
        [Test]
        public void checkForSad()
        {
            string message = "i am in sad mood";
            mood =new MoodAnalyser(message);
            string returnMood = mood.analyseMood();            
            Assert.AreEqual("sad", returnMood);
        }

        /// <checkForHappy>
        /// Calling parameteried constructor
        /// Calling No parameter analyseMood method
        /// checking return mood is "happy" are not
        /// if return mood "happy" then Test passed.
        /// </checkForHappy>
        [Test]
        public void checkForHappy()
        {
            string message = "i am in happy mood";
            mood = new MoodAnalyser(message);
            string returnMood = mood.analyseMood();
            Assert.AreEqual("happy", returnMood);
        }

        /// <checkForNullHappy>
        /// Calling parameteried constructor
        /// Calling No parameter analyseMood method
        /// checking return mood is "happy" are not
        /// if return mood "happy" then Test passed.
        /// </checkForNullHappy>
        [Test]
        public void checkForNullHappy()
        {
            string message = null;
            mood = new MoodAnalyser(message);
            string returnMood = mood.analyseMood();
            Assert.AreEqual("happy", returnMood);
        }
    }
}