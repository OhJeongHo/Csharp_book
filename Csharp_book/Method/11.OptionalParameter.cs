using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Class1
    {
        static int Add(int a, int b = 1)
        {
            return a + b;
        }

        static void Main()
        {
            Console.WriteLine(Add(5));

            Console.WriteLine(Add(5, 3));
        }
    }
}
