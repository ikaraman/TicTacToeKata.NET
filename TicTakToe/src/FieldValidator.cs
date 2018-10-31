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
            var fieldSize = Field.GetFieldSize();
            var isOneOfColumnsWinner = false;

            for (var column = 0; column < fieldSize; column++)
            {
                var isThisColumnWinner = true;
                for (var row = 0; row < fieldSize; row++)
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

            return isOneOfColumnsWinner;
        }
        
        
        public static bool IsThereWinningRow(char currentPlayerSymbol)
        {
            var field = Field.GetField();
            var fieldSize = Field.GetFieldSize();
            var isOneOfRowsWinner = false;

            for (var row = 0; row < fieldSize; row++)
            {
                var isThisRowWinner = true;
                for (var column = 0; column < fieldSize; column++)
                {
                    var isCellEmpty = field[row, column] == Field.GetEmptyCellChar();
                    var isCellMatchCurrentPlayerSymbol = field[row, column] == currentPlayerSymbol;

                    if (isCellEmpty || !isCellMatchCurrentPlayerSymbol)
                    {
                        isThisRowWinner = false;
                    }
                }

                isOneOfRowsWinner = isOneOfRowsWinner || isThisRowWinner;
            }

            return isOneOfRowsWinner;
        }
        
        
        public static bool IsThereWinningTopLeftBottomRightDiagonal(char currentPlayerSymbol)
        {
            var field = Field.GetField();
            var fieldSize = Field.GetFieldSize();
            var isThisDiagonalWinner = true;

            for (var index = 0; index < fieldSize; index++)
            {
                var isCellEmpty = field[index, index] == Field.GetEmptyCellChar();
                var isCellMatchCurrentPlayerSymbol = field[index, index] == currentPlayerSymbol;
                
                if (isCellEmpty || !isCellMatchCurrentPlayerSymbol)
                {
                    isThisDiagonalWinner = false;
                }
            }

            return isThisDiagonalWinner;
        }
        
        
        public static bool IsThereWinningBottomLeftTopRightDiagonal(char currentPlayerSymbol)
        {
            var field = Field.GetField();
            var fieldSize = Field.GetFieldSize();
            var isThisDiagonalWinner = true;

            for (var index = 0; index < fieldSize; index++)
            {
                var isCellEmpty = field[(fieldSize - 1) - index, index] == Field.GetEmptyCellChar();
                var isCellMatchCurrentPlayerSymbol = field[(fieldSize - 1) - index, index] == currentPlayerSymbol;
                
                if (isCellEmpty || !isCellMatchCurrentPlayerSymbol)
                {
                    isThisDiagonalWinner = false;
                }
            }

            return isThisDiagonalWinner;
        }
    }
}