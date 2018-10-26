using System;

namespace TicTakToe
{
    internal static class TheGame
    {
        private static void Main()
        {
            Console.WriteLine("Welcome to the TikTakToe game!");
            Console.WriteLine("Please enter a field size:");
            var size = int.Parse(Console.ReadLine());

            if (GameFieldValidator.IsFieldSizeValid(size))
            {
                var field = new GameField(size);
                Console.WriteLine($"New field created with a size of {size}");
                
                field.DrawGameField();
                Move.MakeMove();
            }
        }
    }
}