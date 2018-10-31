using NUnit.Framework;

namespace TicTakToe
{
    [TestFixture]
    public class MoveIsPlayerGivingUpTest
    {
        [TestCase("q")]
        [TestCase("'q'")]
        public void ShouldReturnTrueForValidInput(string value)
        {
            Assert.AreEqual(true, Move.IsPlayerGivingUp(value));
        }
        
        [TestCase("Q")]
        [TestCase("q ")]
        [TestCase("r")]
        [TestCase("p")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("\n")]
        [TestCase("3")]
        [TestCase("quit")]
        public void ShouldReturnFalseForInvalidValues(string value)
        {
            Assert.AreEqual(false, Move.IsPlayerGivingUp(value));
        }
    }
}