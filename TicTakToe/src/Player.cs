namespace TicTakToe
{
    public static class Player
    {
        private static int _playerNumber = 1;
        
        public static int GetCurrentPlayerNumber()
        {
            return _playerNumber;
        }
        
        public static void SetCurrentPlayerNumber(int number)
        {
            _playerNumber = number;
        }
        
        public static void UpdateCurrentPlayerNumber()
        {
            _playerNumber = (_playerNumber == 1) ? 2 : 1;
        }
       
        public static char GetCurrentPlayerSymbol()
        {
            return GetCurrentPlayerNumber() == 1 ? 'X' : 'O';
        }
    }
}