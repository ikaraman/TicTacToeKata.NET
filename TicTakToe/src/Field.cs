using System;

namespace TicTakToe
{
    public class Field
    {
        private static int Size { get; set; }
        private static char[,] GameField { get; set; }


        private Field(int value)
        {
            Size = value;
            PopulateField();
            SysLogger.DisplayMessageToTheConsole("GameStart");
        }


        public static Field CreateField(int inputSize = 0)
        {
            var size = inputSize;
            if (size == 0)
            {
                SysLogger.DisplayMessageToTheConsole("EnterFieldSize");
                var userSizeInput = Console.ReadLine();
            
                if (!FieldValidator.IsFieldSizeValid(userSizeInput)) return null;
                size = int.Parse(userSizeInput);
            }
            
            return new Field(size);
        }


        public static void UpdateCellState(string moveInput)
        {
            var row = int.Parse(moveInput.Split(Move.GetValidDelimiter())[0]); 
            var column = int.Parse(moveInput.Split(Move.GetValidDelimiter())[1]);

            GameField[ row - 1, column - 1] = Player.GetCurrentPlayerSymbol();
        }


        public static int GetFieldSize()
        {
            return Size;
        }


        public static char[,] GetField()
        {
            return GameField;
        }


        private static void PopulateField()
        {
            GameField = new char[Size, Size];
            for (var row = 0; row < Size; row++)
            {
                for (var column = 0; column < Size; column++)
                {
                    GameField[row, column] = '.';
                }
            }
        }


        public static void DrawField()
        {
            Console.WriteLine("    1 2 3 ");
            Console.WriteLine("  ☻ — — — ►  columns");
            for (var row = 0; row < Size; row++)
            {
                Console.Write(row + 1);
                Console.Write(' ');
                Console.Write('│');
                Console.Write(' ');
                for (var column = 0; column < Size; column++)
                {
                    Console.Write(GameField[row, column]);
                    Console.Write(' ');
                }
                Console.Write(Environment.NewLine);
            }
            Console.WriteLine("▼ ");
            Console.WriteLine("rows");
            Console.Write(Environment.NewLine);
        }


        public static bool IsMoreMovesPossible()
        {
            for (var row = 0; row < Size; row++)
            {
                for (var column = 0; column < Size; column++)
                {
                    if (GameField[row, column] == '.')
                    {
                        return true;
                    }
                }
            }

            SysLogger.DisplayMessageToTheConsole("NoMoreTurns");
            DrawField();
            
            return false;
        }


        public static char GetEmptyCellChar()
        {
            return '.';
        }
        
        
        public static bool IsCellFree(string moveInput)
        {
            var row = int.Parse(moveInput.Split(Move.GetValidDelimiter())[0]); 
            var column = int.Parse(moveInput.Split(Move.GetValidDelimiter())[1]);

            var isCellFree = GameField[row - 1, column - 1] == GetEmptyCellChar();
            if (!isCellFree)
            {
                SysLogger.DisplayMessageToTheConsole("CellOccupied");
            }

            return isCellFree;
        }


        public static bool IsThereWinner()
        {
            var currentPlayerSymbol = Player.GetCurrentPlayerSymbol();

            var isThereWinningColumn = FieldValidator.IsThereWinningColumn(currentPlayerSymbol);
            var isThereWinningRow = FieldValidator.IsThereWinningRow(currentPlayerSymbol);
            var isThereWinningTopLeftBottomRightDiagonal = FieldValidator.IsThereWinningTopLeftBottomRightDiagonal(currentPlayerSymbol);
            var isThereWinningBottomLeftTopRightDiagonal = FieldValidator.IsThereWinningBottomLeftTopRightDiagonal(currentPlayerSymbol);
            
            var isThereWinner = isThereWinningColumn || 
                                isThereWinningRow || 
                                isThereWinningTopLeftBottomRightDiagonal || 
                                isThereWinningBottomLeftTopRightDiagonal;
            
            if (isThereWinner)
            {
                DrawField();
                SysLogger.DisplayMessageToTheConsole("GameOver");
            }

            return isThereWinner;
        }
    }
}