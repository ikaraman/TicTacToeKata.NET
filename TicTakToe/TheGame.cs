using System;

namespace TicTakToe
{
    internal static class TheGame
    {
        private static void Main()
        {
            Console.WriteLine("Welcome to the TikTakToe game!");
            if (Field.CreateField() == null) return;
            
            while (Field.IsMoreMovesPossible())
            {
                Field.DrawField();
                
                var move = Move.NextMove();
                if(Move.IsPlayerGivingUp(move)) return;
                if (Move.IsPlayerInputValid(move))
                {
                    if (Field.IsCellFree(move))
                    {
                        Field.UpdateCellState(move);
                        //if(Field.IsThereWinner()) return;
                        //update current player
                    }
                }
            }
        }
    }
}