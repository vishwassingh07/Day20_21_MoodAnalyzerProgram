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
        /// <summary>
        /// TC2.1 : Given : Null Mood Should Return Happy
        /// </summary>
        [Test]
        public void GivenMessage_WhenNull_ShouldReturnHappy()
        {
            moodanalyzer = new MoodAnalyzer();
            string msg = moodanalyzer.AnalyzeMood();
            Assert.AreEqual("HAPPY", msg);
        }
        /// <summary>
        /// TC3.1 : Given : NULL Mood Should Throw MoodAnalysisException
        /// </summary>
        [Test]
        public void GivenMessage_WhenNull_Should_ShouldReturnNullMood_WithCustomException()
        {
            moodanalyzer = new MoodAnalyzer();
            try
            {
                string msg = moodanalyzer.AnalyzeMood();
            }
            catch(CustomExceptionForMoodAnalyzer exception)
            {
                Assert.AreEqual(CustomExceptionForMoodAnalyzer.ExceptionType.NULL_MOOD, exception.exceptiontype);
            }
        }
        /// <summary>
        /// TC3.2 : Given : Empty Mood Should Throw MoodAnalysisException
        /// </summary>
        [Test]
        public void GivenMessage_WhenEmpty_Should_ShouldReturnNullMood_WithCustomException()
        {
            moodanalyzer = new MoodAnalyzer();
            try
            {
                string msg = moodanalyzer.AnalyzeMood();
            }
            catch (CustomExceptionForMoodAnalyzer exception)
            {
                Assert.AreEqual(CustomExceptionForMoodAnalyzer.ExceptionType.EMPTY_MOOD, exception.exceptiontype);
            }
        }

    }
}
