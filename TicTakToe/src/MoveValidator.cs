using System.Text.RegularExpressions;

namespace TicTakToe
{
    public static class MoveValidator
    {
        private static readonly string ValidDelimiter = Move.GetValidDelimiter();
        private static readonly int FieldSize = Field.GetFieldSize();


        public static bool IsPlayerInputValid(string move)
        {
            var isMoveStringLengthValid = IsMoveStringLengthValid(move);
            if (!isMoveStringLengthValid)
            {
                SysLogger.DisplayMessageToTheConsole("InvalidCoordinates");
                return false;
            }
            
            var isInputDelimiterValid = IsInputDelimiterValid(move);
            var isInputDigitsValid = false;
            if (isInputDelimiterValid)
            {
                isInputDigitsValid = IsInputDigitsValid(move);
            }

            var isInputValid = isInputDelimiterValid && isInputDigitsValid;
            if (!isInputValid) SysLogger.DisplayMessageToTheConsole("InvalidCoordinates");
            
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
        
        
        private static bool IsDigitsOnly(string input)
        {
            var pattern = @"^[\d]+$";
            
            return Regex.Match(input, pattern).Success;
        }


        private static bool IsInputDigitsValid(string move)
        {
            var firstPart = move.Split(Move.GetValidDelimiter())[0];
            var secondPart = move.Split(Move.GetValidDelimiter())[1]; 
            
            if (!IsDigitsOnly(firstPart) || !IsDigitsOnly(secondPart)) return false;
            
            var firstDigit = int.Parse(firstPart);
            var secondDigit = int.Parse(secondPart);
            
            var isFirstDigitValid = firstDigit > 0 && firstDigit <= FieldSize;
            var isSecondDigitValid = secondDigit > 0 && secondDigit <= FieldSize;

            return isFirstDigitValid && isSecondDigitValid;
        }
    }
}