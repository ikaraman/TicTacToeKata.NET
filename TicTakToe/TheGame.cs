﻿using System;

namespace TicTakToe
{
    internal static class TheGame
    {
        private static void Main()
        {
            SysLogger.DisplayMessageToTheConsole("WelcomeToTheGame");
            if (Field.CreateField() == null) return;

            while (Field.IsMoreMovesPossible())
            {
                Field.DrawField();

                var move = Move.PromptForNextMove();
                if (Move.IsPlayerGivingUp(move)) return;
                
                if (Move.IsPlayerInputValid(move))
                {
                    if (Field.IsCellFree(move))
                    {
                        Field.UpdateCellState(move);
                        if (Field.IsThereWinner()) return;
                        Player.UpdateCurrentPlayerNumber();
                    }
                }
            } 
        }
    }
}