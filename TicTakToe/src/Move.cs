using System;

namespace TicTakToe
{
    public static class Move
    { 
        public static string PromptForNextMove()
        {
            SysLogger.DisplayMessageToTheConsole("EnterNextMove");
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
                SysLogger.DisplayMessageToTheConsole("PlayerLostGame"); 
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