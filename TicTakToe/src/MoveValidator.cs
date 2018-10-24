using System;

namespace TicTakToe
{
    public static class MoveValidator
    {
        public static bool IsPlayerGivingUp(string move)
        {
            if (move == "q") return true;

            return false;
        }
        
        public static bool IsMoveValid(string move)
        {
            var inputLength = move.Length;
            var isInputDelimiterValid = (move.Split(",").Length == 2) ? true : false;

            if (inputLength == 3 && isInputDelimiterValid)
            {
                int[] moveDigits = { Int32.Parse(move.Split(",")[0]), Int32.Parse(move.Split(",")[1]) };
                var isFirstDigitValid = (moveDigits[0] > 0 && moveDigits[0] < 4) ? true : false;
                var isSecondDigitValid = (moveDigits[1] > 0 && moveDigits[1] < 4) ? true : false;
                
                if ( isFirstDigitValid && isSecondDigitValid) return true;
            }

            return false;
        }
    }
}