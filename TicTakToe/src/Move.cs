using System;

namespace TicTakToe
{
    public class Move
    {
        public static void MakeMove()
        {
            Console.WriteLine($"Player 1, please enter an x,y coordinates to place your X (from 1,1 to {GameField.Size},{GameField.Size}) or enter 'q' to give up:");
            var move = Console.ReadLine();
            if (MoveValidator.IsPlayerGivingUp(move))
            {
                Console.WriteLine("Player 1 lost the game.");
                return;
            }
            
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