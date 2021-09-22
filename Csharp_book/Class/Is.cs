using System;

namespace Class
{
    class Is
    {
        static void Main()
        {
            object x = 1234;

            if (x is int)
            {
                Console.WriteLine($"{x}는 정수형으로 변환이 가능합니다.");
            }
        }
    }
}
