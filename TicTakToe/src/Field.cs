using System;

namespace TicTakToe
{
    public class Field
    {
        public static int Size { get; private set; }
        private static char[,] GameField { get; set; }

        
        private Field(int value)
        {
            Size = value;
            PopulateField();
            Console.WriteLine("Let the game begin!");
        }

        
        public static Field CreateField(int inputSize = 0)
        {
            var size = inputSize;
            if (size == 0)
            {
                Console.WriteLine("Please, enter a field size:");
                var userSizeInput = Console.ReadLine();
            
                if (!FieldValidator.IsFieldSizeValid(userSizeInput)) return null;
                size = int.Parse(userSizeInput);
            }
            
            return new Field(size);
        }
        
        
        public static int GetFieldSize()
        {
            return Size;
        }
        
        
        private static void PopulateField()
        {
            GameField = new char[Size, Size];
            for (var x = 0; x < Size; x++)
            {
                for (var y = 0; y < Size; y++)
                {
                    GameField[x, y] = '.';
                }
            }
        }

        
        public static void DrawField()
        {
            Console.WriteLine("Here's the current board:");
            Console.WriteLine("▲ y");
            for (var x = 0; x < Size; x++)
            {
                Console.Write('│');
                Console.Write(' ');
                for (var y = 0; y < Size; y++)
                {
                    Console.Write(GameField[x, y]);
                    Console.Write(' ');
                }
                Console.Write(Environment.NewLine);
            }
            Console.WriteLine("☻ — — — ► x");
            Console.Write(Environment.NewLine);
        }
        
        
        public static bool IsMoreMovesPossible()
        {
            for (var x = 0; x < Size; x++)
            {
                for (var y = 0; y < Size; y++)
                {
                    if (GameField[x, y] == '.')
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        
        
        public static bool IsCellFree(string moveInput)
        {
            var x = int.Parse(moveInput.Split(Move.GetValidDelimiter())[0]); 
            var y = int.Parse(moveInput.Split(Move.GetValidDelimiter())[1]);

            var isCellFree = GameField[x - 1, y - 1] == '.';
            if (!isCellFree)
            {
                Console.WriteLine("Whoops, cell is occupied, try again!");
            }

            return isCellFree;
        }
    }
}