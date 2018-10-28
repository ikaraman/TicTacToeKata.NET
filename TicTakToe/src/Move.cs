using System;

namespace TicTakToe
{
    public static class Move
    { 
        public static string NextMove()
        {
            Console.WriteLine($"Player 1, please enter an x,y coordinates to place your X (from 1,1 to {Field.Size},{Field.Size}) or enter 'q' to give up:");
            return Console.ReadLine();
        }
        
        
        public static string GetValidDelimiter()
        {
            return ",";
        }

        
        public static bool IsPlayerGivingUp(string moveInput)
        {
            if (moveInput == "q" || moveInput == "'q'")
            {
                Console.WriteLine("Player 1 lost the game."); //todo fix player numbers
                return true;
            }
            
            return false;
        }
        
        
        public static bool IsPlayerInputValid(string moveInput)
        {
            return MoveValidator.IsPlayerInputValid(moveInput);
        }
    }
}