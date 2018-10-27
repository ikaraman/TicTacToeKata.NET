using System;

namespace TicTakToe
{
    public class Field
    {
        public static int Size { get; private set; }
        private char[,] GameField { get; set; }

        public Field(int value)
        {
            Size = value;
            PopulateGameField();
        }

        private void PopulateGameField()
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

        public void DrawGameField()
        {
            Console.WriteLine("Here's the current board:");
            for (var x = 0; x < Size; x++)
            {
                for (var y = 0; y < Size; y++)
                {
                    Console.Write(GameField[x, y]);
                }
                Console.Write(Environment.NewLine);
            }
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
    }
}