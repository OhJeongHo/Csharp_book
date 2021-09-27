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
            int[] numbers = { 3, 2, 1, 4, 5 };

            IEnumerable<int> methodSyntax =
                numbers.Where(n => n % 2 == 1).OrderBy(n => n);

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }


            // 쿼리 구문
            IEnumerable<int> querySyntax =
                from num in numbers
                where num % 2 == 1
                orderby num
                select num;

            foreach (var n in querySyntax)
            {
                Console.WriteLine(n);
            }
        }
    }
}
