using System;
using System.Collections.Generic;

namespace TicTakToe
{
    public static class FieldValidator
    {
        public static bool IsFieldSizeValid(string userSizeInput)
        {
            if (userSizeInput == "3") return true;
            
            Console.WriteLine("Game field has an incorrect size. Please restart the game with a size '3'.");
            return false;
        }
        
        
        public static bool IsThereWinningColumn(char currentPlayerSymbol)
        {
//            var field = Field.GetField();
//            var size = Field.GetFieldSize();
            var result = false;
            
//            for (var column = 0; column < size ; column++)
//            {
//                List<char> columnValues = new List<char>();
//                for (var row = 0; row < size; row++)
//                {
//                    columnValues.Add(field[row, column]);
//                }
//
//                foreach (var item in columnValues)
//                {
//                    if (item != currentPlayerSymbol)
//                    {
//                        result = false;
//                    }
//                }
//            }

            return result;
        }
        
        
        public static bool IsThereWinningRow(char currentPlayerSymbol)
        {
            var field = Field.GetField();
            return false;
        }
        
        
        public static bool IsThereWinningDiagonal(char currentPlayerSymbol)
        {
            var field = Field.GetField();
            return false;
        }
    }
}