using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Class1
    {
        static int Sum(int first = 10, int second = 20)
        {
            return first + second;
        }

        static void Main()
        {
            Console.WriteLine(Sum(3, 5));   // 8

            Console.WriteLine(Sum());   // 30

            Console.WriteLine(Sum(40)); // 60

            Console.WriteLine(Sum(100, 200));   // 300

            Console.WriteLine(Sum(first: 5, second: 4));    // 9

            Console.WriteLine(Sum(second: 3, first: 2));    // 5

            Console.WriteLine(Sum(second: 50)); // 60
        }
    }
}
