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
            var field = Field.GetField();
            var size = Field.GetFieldSize();
            var isOneOfColumnsWinner = false;

            for (var column = 0; column < size; column++)
            {
                var isThisColumnWinner = true;
                for (var row = 0; row < size; row++)
                {
                    var isCellEmpty = field[row, column] == Field.GetEmptyCellChar();
                    var isCellMatchCurrentPlayerSymbol = field[row, column] == currentPlayerSymbol;

                    if (isCellEmpty || !isCellMatchCurrentPlayerSymbol)
                    {
                        isThisColumnWinner = false;
                    }
                }

                isOneOfColumnsWinner = isOneOfColumnsWinner || isThisColumnWinner;
            }

            if (isOneOfColumnsWinner)
            {
                Field.DrawField();
                
                Console.WriteLine("************************");
                Console.WriteLine("****** Game over! ******");
                Console.WriteLine($"***** Player {Player.GetCurrentPlayerNumber()} won! ****");
                Console.WriteLine("************************");
            }
            
            return isOneOfColumnsWinner;
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