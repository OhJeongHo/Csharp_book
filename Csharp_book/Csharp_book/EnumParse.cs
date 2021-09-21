using System;

namespace Csharp_book
{
    class EnumParse
    {
        static void Main()
        {
            string color = "Red";

            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);

            Console.WriteLine("Red");
            Console.ResetColor();
        }
    }
}
