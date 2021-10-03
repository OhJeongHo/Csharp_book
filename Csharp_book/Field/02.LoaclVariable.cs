using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field
{
    class Class1
    {
        // 변수는 변수가 선언된 블록 내에서만 살아있다.
        // Main() 메소드 내에서 선언된 변수는 Main() 메소드가 종료되면 자동으로 소멸됨.
        public static void Main()
        {
            int i = 1234;
            int j = 2345;
            int k = 3456;

            Console.WriteLine("{0}", i + j + k);
        }
    }
}
