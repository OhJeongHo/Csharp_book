using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field
{
    class Class1
    {
        static string globalVariable = "전역 변수"; // 필드 또는 맴버 변수

        static void Main()
        {
            string localVariable = "지역 변수"; // 1. 지역 변수
            Console.WriteLine(localVariable);

            Console.WriteLine(globalVariable);  // 2-1.전역 변수
            Test();                             // 2-2.
        }

        static void Test() => Console.WriteLine(globalVariable);    // 전역 변수
    }
    // 2-1은 클래스 내에 static 키워드와 함께 전역변수로 선언된 globalVariable 필드를 main()메소드에서 사용하는 형태
    // 2-2는 필드 내용을 main()이 아닌 test메소드에서 사용.
}
