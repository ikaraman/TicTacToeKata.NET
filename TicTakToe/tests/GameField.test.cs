namespace TicTakToe
{
    using NUnit.Framework;

    [TestFixture]
    public class GameFieldValidatorTest
    {
        [Test]
         public void CheckSizeShouldReturnTrueForSize3()
        {
            Assert.AreEqual(true, GameFieldValidator.CheckSize(3));
        }
    }
    
    
    [TestFixture]
    public class MoveValidatorIsPlayerGivingUpTest
    {
        [TestCase("q")]
        [TestCase("'q'")]
        public void ShouldReturnTrueForValidInput(string value)
        {
            Assert.AreEqual(true, MoveValidator.IsPlayerGivingUp(value));
        }
        
        [TestCase("Q")]
        [TestCase("q ")]
        [TestCase("r")]
        [TestCase("p")]
        [TestCase(" ")]
        [TestCase("\n")]
        [TestCase("3")]
        [TestCase("quit")]
        public void ShouldReturnFalseForInvalidValues(string value)
        {
            Assert.AreEqual(false, MoveValidator.IsPlayerGivingUp(value));
        }
    }
    
    
    [TestFixture]
    public class MoveValidatorIsMoveValidTest
    {
        [TestCase("1,1")]
        [TestCase("1,2")]
        [TestCase("1,3")]
        [TestCase("2,1")]
        [TestCase("2,2")]
        [TestCase("2,3")]
        [TestCase("3,1")]
        [TestCase("3,2")]
        [TestCase("3,3")]
        public void ShouldReturnTrueForValidInput(string value)
        {
            Assert.AreEqual(true, MoveValidator.IsMoveValid(value));
        }
        
        [TestCase("0,0")]
        [TestCase("1,0")]
        [TestCase("0,1")]
        [TestCase("0,4")]
        [TestCase("1,4")]
        [TestCase("4,0")]
        [TestCase("4,4")]
        public void ShouldReturnFalseForOutOfFieldRangeValues(string value)
        {
            Assert.AreEqual(false, MoveValidator.IsMoveValid(value));
        }
        
        [TestCase("11")]
        [TestCase("1, 2")]
        [TestCase("2 - 2")]
        public void ShouldReturnFalseForIncorrectLengthValues(string value)
        {
            Assert.AreEqual(false, MoveValidator.IsMoveValid(value));
        }
        
        [TestCase("1.1")]
        [TestCase("1-2")]
        [TestCase("2 2")]
        [TestCase("2/3")]
        [TestCase("3_3")]
        public void ShouldReturnFalseForIncorrectDelimiterValues(string value)
        {
            Assert.AreEqual(false, MoveValidator.IsMoveValid(value));
        }
        
        [TestCase(",11")]
        [TestCase("12,")]
        [TestCase(",1,2")]
        [TestCase("1,2,")]
        public void ShouldReturnFalseForCorrectDelimiterInTheWrongPlace(string value)
        {
            Assert.AreEqual(false, MoveValidator.IsMoveValid(value));
        }
    }
}