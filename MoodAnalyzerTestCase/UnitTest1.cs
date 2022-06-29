using MoodAnalyzerProgram;
using NUnit.Framework;

namespace MoodAnalyzerTestCase
{
    public class Tests
    {
        MoodAnalyzer moodanalyzer;
        [SetUp]
        public void Setup()
        {
            moodanalyzer = new MoodAnalyzer();
        }
        /// <summary>
        /// TC1.1 : Given : "I am in sad mood" should return SAD
        /// </summary>

        [Test]
        public void GivenMessage_WhenSad_ShouldReturnSad_ParameterlessConstructor()
        {
            //Arrange
            moodanalyzer = new MoodAnalyzer();
            string msg = "I am in sad mood";
            //Act
            string message = moodanalyzer.AnalyzeMoodWithoutConstructor(msg);
            //Assert
            Assert.AreEqual("SAD", message);
        }
        /// <summary>
        /// TC1.1.2 : Given : "I am in any mood" should return HAPPY
        /// </summary>
        [Test]
        public void GivenMessage_WhenAny_ShouldReturnHappy_ParameterlessConstructor()
        {
            //Arrange
            moodanalyzer = new MoodAnalyzer();
            string msg = "I am in any mood";
            //Act
            string message = moodanalyzer.AnalyzeMoodWithoutConstructor(msg);
            //Assert
            Assert.AreEqual("HAPPY", message);
        }
        /// <summary>
        /// TC1.1 : Given : "I am in sad mood" should return SAD in constructor
        /// </summary>
        [Test]
        public void GivenMessage_WhenSad_ShouldReturnSad()
        {
            moodanalyzer = new MoodAnalyzer("I am in sad mood");
            string msg = moodanalyzer.AnalyzeMood();
            Assert.AreEqual("SAD", msg);
        }
        /// <summary>
        /// TC1.1.2 : Given : "I am in any mood" should return HAPPY in constructor
        /// </summary>
        [Test]
        public void GivenMessage_WhenHappy_ShouldReturnHappy()
        {
            moodanalyzer = new MoodAnalyzer("I am in Happy mood");
            string msg = moodanalyzer.AnalyzeMood();
            Assert.AreEqual("HAPPY", msg);
        }
    }
}
