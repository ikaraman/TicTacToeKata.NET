using System;

namespace TicTakToe
{
    public static class MoveValidator
    {
        private static readonly string ValidDelimiter = Move.GetValidDelimiter();
        private static readonly int FieldSize = Field.GetFieldSize();
        
        
        public static bool IsPlayerInputValid(string move)
        {
            var isMoveStringLengthValid = IsMoveStringLengthValid(move);
            var isInputDelimiterValid = IsInputDelimiterValid(move);
            
            var isInputDigitsValid = false;
            if (isMoveStringLengthValid && isInputDelimiterValid)
            {
                isInputDigitsValid = IsInputDigitsValid(move);
            }

            var isInputValid = isMoveStringLengthValid && isInputDelimiterValid && isInputDigitsValid;
            if (!isInputValid)
            {
                Console.WriteLine("Coordinates you've entered are not valid. Please, try again!");
            }
            return isInputValid;
        }

        
        private static bool IsMoveStringLengthValid(string move)
        {
            return move.Length == 3;
        }
        
        
        private static bool IsInputDelimiterValid(string move)
        {
            return move[1].ToString() == ValidDelimiter;
        }
        
        
        private static bool IsInputDigitsValid(string move)
        {
            var firstDigit = int.Parse(move.Split(ValidDelimiter)[0]);
            var secondDigit = int.Parse(move.Split(ValidDelimiter)[1]);
            
            var isFirstDigitValid = firstDigit > 0 && firstDigit <= FieldSize;
            var isSecondDigitValid = secondDigit > 0 && secondDigit <= FieldSize;

            return isFirstDigitValid && isSecondDigitValid;
        }
    }
}