using System;

namespace Csharp_book
{
    class ConsoleColorDemo
    {
        static void Main()
        {
            // 전경색
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Blue");
            Console.ResetColor();

            // 배경색
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Red");
            Console.ResetColor();
        }
    }
}


enum 열거형이름
{
    열거형변수1,
    열거형변수2,
    열거형변수3
}