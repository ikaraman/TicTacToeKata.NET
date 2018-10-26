namespace TicTakToe
{
    public static class MoveValidator
    {
        private static string _validDelimiter = ",";
        private static int _fieldSize = 3;
        
        public static bool IsPlayerGivingUp(string move)
        {
            return move == "q" || move == "'q'";
        }
        
        public static bool IsMoveValid(string move)
        {
            var isMoveStringLengthValid = IsMoveStringLengthValid(move);
            var isInputDelimiterValid = IsInputDelimiterValid(move);
            
            var isInputDigitsValid = false;
            if (isMoveStringLengthValid && isInputDelimiterValid)
            {
                isInputDigitsValid = IsInputDigitsValid(move);
            }

            return isMoveStringLengthValid && isInputDelimiterValid && isInputDigitsValid;
        }

        private static bool IsMoveStringLengthValid(string move)
        {
            return move.Length == 3;
        }
        
        private static bool IsInputDelimiterValid(string move)
        {
            return move[1].ToString() == _validDelimiter;
        }
        
        private static bool IsInputDigitsValid(string move)
        {
            var firstDigit = int.Parse(move.Split(_validDelimiter)[0]);
            var secondDigit = int.Parse(move.Split(_validDelimiter)[1]);
            
            var isFirstDigitValid = firstDigit > 0 && firstDigit <= _fieldSize;
            var isSecondDigitValid = secondDigit > 0 && secondDigit <= _fieldSize;

            return isFirstDigitValid && isSecondDigitValid;
        }
    }
}