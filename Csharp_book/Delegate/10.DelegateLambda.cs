using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Class1
    {
        delegate bool Lambda(string msg, int len);

        delegate void Hi();

        static void Main()
        {
            Lambda isLong = (string msg, int len) => msg.Length > len;  // 람다식에 형식 선언

            Console.WriteLine(isLong("안녕하세요.", 5));
            Console.WriteLine(isLong("반갑습니다.", 10));


            Hi hi = () =>
            {
                Console.WriteLine("안녕하세요.");
                Console.WriteLine("반갑습니다.");
            };
            hi();
        }
    }
}
