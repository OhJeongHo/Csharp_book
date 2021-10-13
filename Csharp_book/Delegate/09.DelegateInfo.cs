using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Class1
    {
        // 대리자에 람다식으로 바로 만들어서 사용.
        delegate int IntParameterAndIntReturnDelegate(int x);

        // 대리자 개체에 람다식 담기
        // 대리자 개체에 람다 식을 담아 대신 호출할 수 있다.
        delegate void Lambda();


        // 매개변수도 있고 반환값도 있는 경우의 람다식
        delegate int Lambda2(int i);

        static void Main()
        {
            IntParameterAndIntReturnDelegate pow = (x) => x * x;
            Console.WriteLine(pow(3));

            // 매개변수가 없는 람다 식은 () => 본문 형태로 구현
            Lambda hi = () => Console.WriteLine("안녕하세요.");
            hi();

            Lambda2 square = x => x * x;
            Console.WriteLine(square(3));
        }
    }
}
