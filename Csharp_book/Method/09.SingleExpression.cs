using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 단일 표현식의 메소드를 한 줄로 정의하기
// 결과값이 하나인 단일 표현식일 때는 화살표 기호로 메소드 본문을 줄여 표현할 수 있다.


namespace Method
{
    class Class1
    {
        static int AddAge(int age) => age + 1;  // return age + 1의 축약 형식

        static void Main() => Console.WriteLine(AddAge(100));
    }
}
