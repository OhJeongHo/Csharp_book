using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 문자열 배열을 받는 가변 길이 매개변수 사용.

namespace Method
{
    class Class1
    {
        static void Main()
        {
            Multi("A");

            Multi("A", "B");

            Multi("A", "B", "C");
        }

        static void Multi(params string[] messages)
        {
            foreach (string message in messages)
            {
                Console.WriteLine(message);
            }
            Console.WriteLine();
        }
    }
}
