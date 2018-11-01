using NUnit.Framework;

namespace TicTakToe
{
    [TestFixture]
    public class GetCurrentPlayerNumber
    {
        [SetUp] public void SetPlayerNumberToOne()
        {
            Player.SetCurrentPlayerNumber(1);
        }
        
        [Test]
        public void ShouldReturnOneByDefault()
        {
            Assert.AreEqual(1, Player.GetCurrentPlayerNumber());
        }
        
        [Test]
        public void ShouldReturnTwoAfterPlayerNumberHasBeenUpdated()
        {
            Player.UpdateCurrentPlayerNumber();
            Assert.AreEqual(2, Player.GetCurrentPlayerNumber());
        }
        
        [Test]
        public void ShouldReturnOneAfterTwoPlayerNumberUpdates()
        {
            Player.UpdateCurrentPlayerNumber();
            Player.UpdateCurrentPlayerNumber();
            Assert.AreEqual(1, Player.GetCurrentPlayerNumber());
        }
    }
    
    [TestFixture]
    public class GetCurrentPlayerSymbol
    {
        [SetUp] public void SetPlayerNumberToOne()
        {
            Player.SetCurrentPlayerNumber(1);
        }
        
        [Test]
        public void ShouldReturnXByDefault()
        {
            Assert.AreEqual('X', Player.GetCurrentPlayerSymbol());
        }
        
        [Test]
        public void ShouldReturnOAfterPlayerNumberHasBeenUpdated()
        {
            Player.UpdateCurrentPlayerNumber();
            Assert.AreEqual('O', Player.GetCurrentPlayerSymbol());
        }
        
        [Test]
        public void ShouldReturnXAfterTwoPlayerNumberUpdates()
        {
            Player.UpdateCurrentPlayerNumber();
            Player.UpdateCurrentPlayerNumber();
            Assert.AreEqual('X', Player.GetCurrentPlayerSymbol());
        }
        
        [Test]
        public void ShouldReturnOAfterThreePlayerNumberUpdates()
        {
            Player.UpdateCurrentPlayerNumber();
            Player.UpdateCurrentPlayerNumber();
            Player.UpdateCurrentPlayerNumber();
            Assert.AreEqual('O', Player.GetCurrentPlayerSymbol());
        }
    }
}