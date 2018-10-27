using System;

namespace TicTakToe
{
    public static class Move
    {
        public static void MakeMove()
        {
            Console.WriteLine($"Player 1, please enter an x,y coordinates to place your X (from 1,1 to {Field.Size},{Field.Size}) or enter 'q' to give up:");
            var move = Console.ReadLine();
            if (MoveValidator.IsPlayerGivingUp(move))
            {
                Console.WriteLine("Player 1 lost the game.");
                return;
            }
            
            if (MoveValidator.IsPlayerInputValid(move))
            {
                Console.WriteLine("Valid input!"); //todo
                //check if cell occupied
                //update the field
            }
            else
            {
                Console.WriteLine("Invalid move!");
                //try again
            }
        }
    }
}