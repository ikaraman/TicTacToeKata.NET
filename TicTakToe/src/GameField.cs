using System;

namespace TicTakToe
{
    public class GameField
    {
        public int Size { get; }

        public GameField(int size)
        {
            this.Size = size;
        }
    }

    public class GameFieldValidator
    {
        public static bool CheckSize(int size)
        {
            if (size != 3)
            {
                Console.WriteLine("Game field has an incorrect size. Please restart the game with a size '3'.");
                return false;
            }
            
            return true;
        }
    }
}