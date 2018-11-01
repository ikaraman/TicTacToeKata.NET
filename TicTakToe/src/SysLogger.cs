using System;

namespace TicTakToe
{
    public static class SysLogger
    {
        public static void DisplayMessageToTheConsole(string messageType)
        {
            switch (messageType)
            {
                case "NoMoreTurns":
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("There are no more turns available. Game over!");
                    Console.WriteLine("---------------------------------------------");
                    break;
                case "CellOccupied":
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Whoops, cell is occupied, try again!");
                    Console.WriteLine("------------------------------------");
                    break;
                case "GameOver":
                    Console.WriteLine("------------------------");
                    Console.WriteLine("------ Game over! ------");
                    Console.WriteLine($"----- Player {Player.GetCurrentPlayerNumber()} won! ----");
                    Console.WriteLine("------------------------");
                    break;
                case "InvalidCoordinates":
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("Coordinates you've entered are not valid. Please, try again!");
                    Console.WriteLine("------------------------------------------------------------");
                    break;
                case "InvalidFieldSize":
                    Console.WriteLine("--------------------------------------------------------------------------");
                    Console.WriteLine("Game field has an incorrect size. Please restart the game with a size '3'.");
                    Console.WriteLine("--------------------------------------------------------------------------");
                    break;
                case "PlayerLostGame":
                    Console.WriteLine($"Player {Player.GetCurrentPlayerNumber()} lost the game.");
                    break;
                case "WelcomeToTheGame":
                    Console.WriteLine("Welcome to the TikTakToe game!");
                    break;
                case "GameStart":
                    Console.WriteLine("Let the game begin!");
                    break;
                case "EnterFieldSize":
                    Console.WriteLine("Please, enter a field size:");
                    break;
                case "EnterNextMove":
                    Console.WriteLine($"Player {Player.GetCurrentPlayerNumber()}, please enter an x,y coordinates (row, column) " +
                                      $"to place your {Player.GetCurrentPlayerSymbol()} " +
                                      $"(from 1,1 to {Field.GetFieldSize()},{Field.GetFieldSize()}) or enter 'q' to give up:");
                    break;
            }
        }
    }
}