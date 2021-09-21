using System;

// 열거형 변수인 animal을 정수형으로 변환하여 출력하면 각 맴버가 가지는 인덱스 값이 출력되고,
// 문자열로 변환하여 출력하면 각 맴버 이름이 출력된다.

namespace Csharp_book
{
    enum Animal { Rabbit, Dragon, Snake }
    class EnumIndex
    {
        static void Main()
        {
            Animal animal = Animal.Dragon;
            int num = (int)animal;
            string str = animal.ToString();
            Console.WriteLine($"Animal.Dragon : {num}, {str}");
        }
    }
}
