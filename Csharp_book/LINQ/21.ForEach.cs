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
            var numbers = new List<int>() { 10, 20, 30, 40, 50 };
            numbers.Where(n => n <= 20).ToList().ForEach(n => Console.WriteLine(n));

            var names = new List<string>() { "RedPlus", "Taeyo" };
            names.ForEach(n => Console.WriteLine(n));

            // 20보다 같거나 작은 정수를 출력하는 코드를 foreach문을 사용하지 않고 하나의 코드 흐름에 묶어서 관리함.
        }
    }
}
