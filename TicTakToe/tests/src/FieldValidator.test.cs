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
        
        
        [Test]
        public void IsThereWinningColumnShouldBeTrueForFirstColumn()
        {
            Field.CreateField(3);
            Field.UpdateCellState("1,1");
            Field.UpdateCellState("2,1");
            Field.UpdateCellState("3,1");
            
            Assert.AreEqual(true, FieldValidator.IsThereWinningColumn('X'));
        }
        
        [Test]
        public void IsThereWinningColumnShouldBeTrueForSecondColumn()
        {
            Field.CreateField(3);
            Field.UpdateCellState("1,2");
            Field.UpdateCellState("2,2");
            Field.UpdateCellState("3,2");
            
            Assert.AreEqual(true, FieldValidator.IsThereWinningColumn('X'));
        }
        
        [Test]
        public void IsThereWinningColumnShouldBeTrueForThirdColumn()
        {
            Field.CreateField(3);
            Field.UpdateCellState("1,3");
            Field.UpdateCellState("2,3");
            Field.UpdateCellState("3,3");
            
            Assert.AreEqual(true, FieldValidator.IsThereWinningColumn('X'));
        }
    }
}