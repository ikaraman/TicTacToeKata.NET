using System;

namespace TicTakToe
{
    public class GameField
    {
        private int Size { get; set; }
        private char[,] Field { get; set; }

        public GameField(int size)
        {
            Size = size;
            Field = new char[size, size];
            PopulateGameField();
        }

        private void PopulateGameField()
        {
            for (var x = 0; x < Size; x++)
            {
                for (var y = 0; y < Size; y++)
                {
                    Field[x, y] = '*';
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
                        Console.Write(Field[x, y]);
                    }
                    Console.Write(Environment.NewLine);
                }
                Console.Write(Environment.NewLine);
            }
    }
}