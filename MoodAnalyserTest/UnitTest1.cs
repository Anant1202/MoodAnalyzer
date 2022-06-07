using MoodAnalyzer;
namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnSad()
        {
            //Arrange
            string expected="sad";
            string message="I am in SAD mood";
            analyseMood obj1 = new analyseMood(message);
            //Act
            string mood = obj1.AnalysingMood();
            //Assert
            Assert.AreEqual(expected, mood);
        }
        [TestMethod]
        [DataRow("I am in Happy Mood")]
        [DataRow(null)]
        public void GivenHappyMoodShouldReturnHappy(string message)
        {
            //Arrange
            string expected = "happy";
            analyseMood obj2=new analyseMood(message);
            //Act
            string mood = obj2.AnalysingMood();
            //Assert
            Assert.AreEqual(expected, mood);
        }
    }
}