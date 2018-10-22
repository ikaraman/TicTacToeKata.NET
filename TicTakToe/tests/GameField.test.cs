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
}