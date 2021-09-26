using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Class1
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            // 배열에서 홀수만 추출
            var q = arr.Where(num => num % 2 == 1);
            foreach (var n in q)
            {
                Console.WriteLine(n);
            }
        }
    }
}
