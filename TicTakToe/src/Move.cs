using System;

namespace TicTakToe
{
    public static class Move
    { 
        public static string NextMove()
        {
            Console.WriteLine($"Player {Player.GetCurrentPlayerNumber()}, please enter an x,y coordinates (row, column) " +
                              $"to place your {Player.GetCurrentPlayerSymbol()} " +
                              $"(from 1,1 to {Field.GetFieldSize()},{Field.GetFieldSize()}) or enter 'q' to give up:");
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

                Console.WriteLine($"Player {Player.GetCurrentPlayerNumber()} lost the game."); 
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