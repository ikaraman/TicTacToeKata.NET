using System;

namespace TicTakToe
{
    public static class GameFieldValidator
    {
        public static bool CheckSize(int size)
        {
            if (size == 3) return true;
            
            Console.WriteLine("Game field has an incorrect size. Please restart the game with a size '3'.");
            return false;
        }
    }
}