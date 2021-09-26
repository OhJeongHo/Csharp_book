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
            // Count() 같은 확장 메소드는 Where() 메소드를 사용하지 않고도 바로 배개변수로 람다식을 전달하여 조건 처리 가능.

            bool[] blns = { true, false, true, false, true };

            Console.WriteLine(blns.Count());
            Console.WriteLine(blns.Count(bln => bln == true));
            Console.WriteLine(blns.Count(bln => bln == false));
        }
    }
}
