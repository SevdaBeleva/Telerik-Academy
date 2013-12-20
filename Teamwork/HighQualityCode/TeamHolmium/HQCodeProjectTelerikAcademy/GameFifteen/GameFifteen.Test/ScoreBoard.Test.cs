using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameFifteen.Test
{
    [TestClass]
    public class ScoreBoardTest
    {
        [TestMethod]
        public void ToStringVisualisationWithOneEntry()
        {
            // Arange 
            ScoreBoard testScore = new ScoreBoard();
            // Act
            testScore.SetPlayerScore("Test User", 25);
            string result = testScore.ToString();
            // Assert
            Assert.AreEqual("Test User <-> 25\n", result);
        }

        [TestMethod]
        public void ToStringVisualisationWithNoEntries()
        {
            // Arange
            ScoreBoard testScore = new ScoreBoard();
            // Act
            string result = testScore.ToString();
            // Assert
            Assert.AreEqual("No new entries yet.", result);
        }
    }
}
