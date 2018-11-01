using NUnit.Framework;

namespace TicTakToe.tests
{
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
        
        [Test]
        public void IsThereWinningColumnShouldBeFalseWhenNoThereIsNoWinningColumn()
        {
            Field.CreateField(3);
            Field.UpdateCellState("1,3");
            
            Assert.AreEqual(false, FieldValidator.IsThereWinningColumn('O'));
        }
        
        [Test]
        public void IsThereWinningRowShouldBeTrueForFirstRow()
        {
            Field.CreateField(3);
            Field.UpdateCellState("1,1");
            Field.UpdateCellState("1,2");
            Field.UpdateCellState("1,3");
            
            Assert.AreEqual(true, FieldValidator.IsThereWinningRow('X'));
        }
        
        [Test]
        public void IsThereWinningRowShouldBeTrueForSecondRow()
        {
            Field.CreateField(3);
            Field.UpdateCellState("2,1");
            Field.UpdateCellState("2,2");
            Field.UpdateCellState("2,3");
            
            Assert.AreEqual(true, FieldValidator.IsThereWinningRow('X'));
        }
        
        [Test]
        public void IsThereWinningRowShouldBeTrueForThirdRow()
        {
            Field.CreateField(3);
            Field.UpdateCellState("3,1");
            Field.UpdateCellState("3,2");
            Field.UpdateCellState("3,3");
            
            Assert.AreEqual(true, FieldValidator.IsThereWinningRow('X'));
        }
        
        [Test]
        public void IsThereWinningRowShouldBeFalseIfThereIsNoWinningRow()
        {
            Field.CreateField(3);
            Field.UpdateCellState("3,1");
            Field.UpdateCellState("3,2");
            
            Assert.AreEqual(false, FieldValidator.IsThereWinningRow('O'));
        }
        
        [Test]
        public void IsThereWinningTopLeftBottomRightDiagonalShouldReturnTrue()
        {
            Field.CreateField(3);
            Field.UpdateCellState("1,1");
            Field.UpdateCellState("2,2");
            Field.UpdateCellState("3,3");
            
            Assert.AreEqual(true, FieldValidator.IsThereWinningTopLeftBottomRightDiagonal('X'));
        }
        
        [Test]
        public void IsThereWinningTopLeftBottomRightDiagonalShouldReturnFalse()
        {
            Field.CreateField(3);
            Field.UpdateCellState("1,1");
            Field.UpdateCellState("2,2");
            
            Assert.AreEqual(false, FieldValidator.IsThereWinningTopLeftBottomRightDiagonal('O'));
        }
        
        [Test]
        public void IsThereWinningBottomLeftTopRightDiagonalShouldReturnTrue()
        {
            Field.CreateField(3);
            Field.UpdateCellState("3,1");
            Field.UpdateCellState("2,2");
            Field.UpdateCellState("1,3");
            
            Assert.AreEqual(true, FieldValidator.IsThereWinningBottomLeftTopRightDiagonal('X'));
        }
        
        [Test]
        public void IsThereWinningBottomLeftTopRightDiagonalShouldReturnFalse()
        {
            Field.CreateField(3);
            Field.UpdateCellState("3,1");
            Field.UpdateCellState("2,2");
            
            Assert.AreEqual(false, FieldValidator.IsThereWinningBottomLeftTopRightDiagonal('O'));
        }
    }
}