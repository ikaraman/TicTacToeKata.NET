using System;

namespace TicTakToe
{
    public class GameField
    {
        private char[,] Field { get; set; }

        public static int Size
        {
            get => Size;
            private set => Size = value;
        }

        public GameField(int value)
        {
            Size = value;
            PopulateGameField();
        }

        private void PopulateGameField()
        {
            Field = new char[Size, Size];
            for (var x = 0; x < Size; x++)
            {
                for (var y = 0; y < Size; y++)
                {
                    Field[x, y] = '.';
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
        
        public void MakeMove()
        {
            Console.WriteLine($"Player 1, please enter an x,y coordinates to place your X (from 1,1 to {Size},{Size}) or enter 'q' to give up:");
        }
    }
}