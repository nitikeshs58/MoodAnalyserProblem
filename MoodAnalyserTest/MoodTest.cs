using NUnit.Framework;
using MoodAnalyserProblem;
using System.Reflection;
using System;

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

        /// <checkForNullException>
        /// passing "null" in parameteried constructor
        /// Calling No parameter analyseMood method
        /// checking return mood is "null input passed"
        /// if return mood "null input passed" then Test passed.
        /// </checkForNullException>
        [Test]
        public void checkForNullException()
        {
            string message = null;
            mood = new MoodAnalyser(message);
            string returnMood = mood.analyseMood();
            Assert.AreEqual("null input passed", returnMood);
        }

        /// <checkForEmptyMoodException>
        /// passing "null" in parameteried constructor
        /// Calling No parameter analyseMood method
        /// checking return mood is "null input passed"
        /// if return mood "null input passed" then Test passed.
        /// </checkForEmptyMoodException>
        [Test]
        public void checkForEmptyMoodException()
        {
            string message = "";
            mood = new MoodAnalyser(message);
            string returnMood = mood.analyseMood();
            Assert.AreEqual("String is empty", returnMood);
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void checkMoodAnalyserObject_withDefaultConstructor()
        {
            MoodAnalyserFactory moodFactoryObject = new MoodAnalyserFactory();
            object expected = new MoodAnalyser();
            object returnObject =  moodFactoryObject.GetInstance("MoodAnalysis", "MoodAnalysis");
            expected.Equals(returnObject);                  
            Assert.AreEqual(expected,returnObject);
        }
    }
}