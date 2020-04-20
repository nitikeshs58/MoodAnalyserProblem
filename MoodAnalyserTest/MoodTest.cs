using NUnit.Framework;
using MoodAnalyserProblem;
using System.Reflection;
using System;

namespace Tests
{
    public class Tests
    {

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
        public void CheckForSad()
        {
            string message = "i am in sad mood";
            MoodAnalyser mood =new MoodAnalyser(message);
            string returnMood = mood.AnalyseMood();            
            Assert.AreEqual("sad", returnMood);
        }

        /// <checkForHappy>
        /// Calling parameteried constructor
        /// Calling No parameter analyseMood method
        /// checking return mood is "happy" are not
        /// if return mood "happy" then Test passed.
        /// </checkForHappy>
        [Test]
        public void CheckForHappy()
        {
            string message = "i am in happy mood";
            MoodAnalyser mood = new MoodAnalyser(message);
            string returnMood = mood.AnalyseMood();
            Assert.AreEqual("happy", returnMood);
        }

        /// <checkForNullException>
        /// passing "null" in parameteried constructor
        /// Calling No parameter analyseMood method
        /// checking return mood is "null input passed"
        /// if return mood "null input passed" then Test passed.
        /// </checkForNullException>
        [Test]
        public void CheckForNullException()
        {
            string message = null;
            MoodAnalyser mood = new MoodAnalyser(message);
            string returnMood = mood.AnalyseMood();
            Assert.AreEqual("null input passed", returnMood);
        }

        /// <checkForEmptyMoodException>
        /// passing "null" in parameteried constructor
        /// Calling No parameter analyseMood method
        /// checking return mood is "null input passed"
        /// if return mood "null input passed" then Test passed.
        /// </checkForEmptyMoodException>
        [Test]
        public void CheckForEmptyMoodException()
        {
            string message = "";
            MoodAnalyser mood = new MoodAnalyser(message);
            string returnMood = mood.AnalyseMood();
            Assert.AreEqual("String is empty", returnMood);
        }


        [Test]
        public void CheckFordefaultConstructor()
        {
                MoodAnalyser mood = new MoodAnalyser();
                MoodAnalyserFactory<MoodAnalyser> moodFact = new MoodAnalyserFactory<MoodAnalyser>();
                ConstructorInfo returnObject = moodFact.GetConstructor();
<<<<<<< HEAD
                object moodAnalyserObject = new MoodAnalyser();
                object constructor = moodFact.GetInstance("MoodAnalyser", returnObject);
                Assert.AreEqual(moodAnalyserObject, constructor);
=======
               // object moodAnalyserObject = new MoodAnalyser();
                object constructor = moodFact.GetInstance("MoodAnalyser", returnObject);
                Assert.IsInstanceOf(typeof(MoodAnalyser), constructor);
>>>>>>> UC5_ReflectionParameterConstructor
            
        }
        [Test]
        public void CheckForClassNotFound()
        {
            try
            {
                MoodAnalyserFactory<MoodAnalyser> moodFact = new MoodAnalyserFactory<MoodAnalyser>();
                var returnObject = moodFact.GetConstructor();
                var constructor = moodFact.GetInstance("MoodAnalyser", returnObject);
            }
<<<<<<< HEAD
            catch (Exception exception)
            {
                Assert.AreEqual("No such class found", exception.Message);
            }
        }

        [Test]
        public void CheckForMethodNotFound()
        {
            try
            {
                MoodAnalyserFactory<MoodAnalyser> moodFact = new MoodAnalyserFactory<MoodAnalyser>();
                var returnObject = moodFact.GetConstructor();
                ConstructorInfo mood = null;
                var constructor = moodFact.GetInstance("MoodAnalyser", mood);
            }
            catch (Exception exception)
            {
                Assert.AreEqual("No such method found", exception.Message);
=======
            catch (Exception e)
            {
                Assert.AreEqual("No such class found", e.Message);
            }
        }

        [Test]
        public void CheckForMethodNotFound()
        {
            try
            {
                MoodAnalyserFactory<MoodAnalyser> moodFact = new MoodAnalyserFactory<MoodAnalyser>();
                var returnObject = moodFact.GetConstructor();
                ConstructorInfo mood = null;
                var constructor = moodFact.GetInstance("MoodAnalyser", mood);
            }
            catch (Exception exception)
            {
                Assert.AreEqual("No such method found", exception.Message);
            }
        }

        [Test]
        public void CheckForParamterisedConstructor()
        {
            MoodAnalyser mood = new MoodAnalyser("i am in sad mood");
            MoodAnalyserFactory<MoodAnalyser> analyser = new MoodAnalyserFactory<MoodAnalyser>();
            ConstructorInfo returnObject = analyser.ParameterisedConstructor(1);
            object constructor = analyser.GetInstance("MoodAnalyzer", returnObject, "i am in sad mood");
            Assert.IsInstanceOf(typeof(MoodAnalyser), constructor);

        }

        [Test]
        public void CheckForClassNotFoundForParameterisedConstructor()
        {
            try
            {
                MoodAnalyserFactory<MoodAnalyser> analyser = new MoodAnalyserFactory<MoodAnalyser>();
                ConstructorInfo returnObject = analyser.ParameterisedConstructor(1);
                object constructor = analyser.GetInstance("mood",returnObject,"i am in sad mood");
            }

            catch (Exception ex)
            {
               Assert.AreEqual("class not found", ex.Message);
            }
        }


        [Test]
        public void CheckForMethodNotFoundForParameterisedConstructor()
        {
            try
            {
                MoodAnalyserFactory<MoodAnalyser> analyser = new MoodAnalyserFactory<MoodAnalyser>();
                ConstructorInfo returnObject = analyser.ParameterisedConstructor(1);
                ConstructorInfo mood = null;
                object constructor = analyser.GetInstance("MoodAnalyzer", mood,"i am in sad mood");
            }
            catch (Exception exe)
            {
                Assert.AreEqual("method not found", exe.Message);
>>>>>>> UC5_ReflectionParameterConstructor
            }
        }
    }
}