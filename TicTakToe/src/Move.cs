using System;

namespace TicTakToe
{
    public static class Move
    { 
        public static string NextMove()
        {
            //todo player numeration & symbol update!
            Console.WriteLine($"Player 1, please enter an x,y coordinates (row, column) to place your X (from 1,1 to {Field.GetFieldSize()},{Field.GetFieldSize()}) or enter 'q' to give up:");
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
                //todo fix player numbers
                Console.WriteLine("Player 1 lost the game."); 
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