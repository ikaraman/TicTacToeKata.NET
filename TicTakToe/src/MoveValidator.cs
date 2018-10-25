namespace TicTakToe
{
    public static class MoveValidator
    {
        private const string validDelimiter = ",";
        
        public static bool IsPlayerGivingUp(string move)
        {
            return move == "q";
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
            return move.Split(validDelimiter).Length == 2;
        }
        
        private static bool IsInputDigitsValid(string move)
        {
            var firstDigit = int.Parse(move.Split(validDelimiter)[0]);
            var secondDigit = int.Parse(move.Split(validDelimiter)[1]);
            
            var isFirstDigitValid = firstDigit > 0 && firstDigit < 4;
            var isSecondDigitValid = secondDigit > 0 && secondDigit < 4;

            return isFirstDigitValid && isSecondDigitValid;
        }
    }
}