using System;

namespace TicTakToe
{
    internal static class TheGame
    {
        private static void Main()
        {
            Console.WriteLine("Welcome to the TikTakToe game!");
            if (Field.CreateField() == null) return;
            Field.DrawField();
            
            if (!FieldValidator.IsFieldSizeValid(userSizeInput)) return;
            var size = int.Parse(userSizeInput);
            {
                var field = new Field(size);
                Console.WriteLine($"New field created with a size of {size}");
                
                field.DrawGameField();
                Move.MakeMove();
            }
        }
    }
}