using NUnit.Framework;

namespace TicTakToe
{
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
            MoveValidator.FieldSize = 3;
            Assert.AreEqual(true, MoveValidator.IsPlayerInputValid(value));
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
            Assert.AreEqual(false, MoveValidator.IsPlayerInputValid(value));
        }
        
        [TestCase("11")]
        [TestCase("1, 2")]
        [TestCase("2 - 2")]
        public void ShouldReturnFalseForIncorrectLengthValues(string value)
        {
            Assert.AreEqual(false, MoveValidator.IsPlayerInputValid(value));
        }
        
        [TestCase("1.1")]
        [TestCase("1-2")]
        [TestCase("2 2")]
        [TestCase("2/3")]
        [TestCase("3_3")]
        public void ShouldReturnFalseForIncorrectDelimiterValues(string value)
        {
            Assert.AreEqual(false, MoveValidator.IsPlayerInputValid(value));
        }
        
        [TestCase(",11")]
        [TestCase("12,")]
        [TestCase(",1,2")]
        [TestCase("1,2,")]
        public void ShouldReturnFalseForCorrectDelimiterInTheWrongPlace(string value)
        {
            Assert.AreEqual(false, MoveValidator.IsPlayerInputValid(value));
        }
    }
}