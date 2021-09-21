using System;

// ConsoleColor 같은 열거형의 모든 맴버를 문자여 배열로 얻을 때는 Enum.GetNames() 메소드에 해당 열거형 형식을 typeof 연산자로 지정.

namespace Csharp_book
{
    class EnumGetNames
    {
        static void Main()
        {
            Type cc = typeof(ConsoleColor); // ConsoleColor 열거형의 Type을 cc 변수에 저장

            string[] colors = Enum.GetNames(cc);    // 모든 색상의 이름 반환

            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
