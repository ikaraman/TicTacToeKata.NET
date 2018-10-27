namespace TicTakToe
{
    using NUnit.Framework;

    [TestFixture]
    public class FieldValidatorTest
    {
        [Test]
         public void CheckSizeShouldReturnTrueForSize3()
        {
            Assert.AreEqual(true, FieldValidator.IsFieldSizeValid("3"));
        }
    }
}