using NUnit.Framework;
using MoodAnalyserProblem;

namespace Tests
{
    public class Tests
    {
        MoodAnalyser mood = new MoodAnalyser();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void checkForSad()
        {
            string returnMood = mood.analyseMood("i am in sad mood");            
            Assert.AreEqual("sad", returnMood);
        }

        [Test]
        public void checkForHappy()
        {
            string returnMood = mood.analyseMood("i am in happy mood");
            Assert.AreEqual("happy", returnMood);
        }
    }
}