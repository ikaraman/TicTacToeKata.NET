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

            if (GameFieldValidator.CheckSize(size))
            {
                var field = new GameField(size);
                Console.WriteLine($"New field created with a size of {size}");
                
                field.DrawGameField();
                field.MakeMove();
                
                var move = Console.ReadLine();
                if (MoveValidator.IsPlayerGivingUp(move))
                {
                    Console.WriteLine("Player 1 lost the game.");
                }
                else
                {
                    if (MoveValidator.IsMoveValid(move))
                    {
                        Console.WriteLine("Valid move!"); //todo
                        //update the field
                    }
                    else
                    {
                        Console.WriteLine("Invalid move!"); //todo: cell occupied, out of boundaries
                        //try again
                    }
                }
            }
        }
    }
}