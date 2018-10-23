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

            if ( GameFieldValidator.CheckSize(size) )
            {
                var field = new GameField(size);
                Console.WriteLine($"New field created with a size of {size}");
                
                field.DrawGameField();
                Console.WriteLine($"Player 1, please enter an x,y coordinates to place your X (from 1,1 to {size},{size}):");
            }
        }
    }
}