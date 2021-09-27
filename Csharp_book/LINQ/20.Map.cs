using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Select() 확장 메소드를 사용해서 새로운 형태로 가공하기

namespace LINQ
{
    class Class1
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            var nums = numbers.Select(it => it * it);

            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }

            var names = new List<string> { "백승수", "이세영", "권경민" };

            // Select() 확장 메소드에서 익명 형식을 사용하기에 var로 받아야 함.
            var nameObjects = names.Select(n => new { Name = n });

            foreach (var name in nameObjects)
            {
                Console.WriteLine(name.Name);
            }
        }
    }
}
