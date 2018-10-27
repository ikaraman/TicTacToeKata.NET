using System;

namespace TicTakToe
{
    public static class FieldValidator
    {
        public static bool IsFieldSizeValid(string userSizeInput)
        {
            if (userSizeInput == "3") return true;
            
            Console.WriteLine("Game field has an incorrect size. Please restart the game with a size '3'.");
            return false;
        }
    }
}