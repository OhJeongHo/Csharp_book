using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 익명 형식 = 무명형식 = 이름 없는 개체 -> 클래스를 선언하지 않고 개체를 만드는 방법
 */

namespace ClassAndObject
{
    class Class1
    {
        static void Main()
        {
            // 개체 만들기 : 익명 형식
            var hong = new { Name = "백승수", Age = 21 };
            var park = new { Name = "박문수", Age = 30 };

            // 개체 사용
            Console.WriteLine($"이름 : {hong.Name}, 나이 : {hong.Age}");
            Console.WriteLine($"이름 : {park.Name}, 나이 : {park.Age}");

            // 익명 형식은 특정 클래스 없이 이름 하나로 여러 속성을 모아 관리할때 유용.
            // 익명 형식을 만들 때 각 데이터 형식은 자동으로 유추해서 만든다.
            // 다음 코드의 IsPrint는 true로 초기화되어 자동으로 불 형식의 데이터가 됩니다.

            var o = new { Id = 1, Note = "Anonymous Type", IsPrint = true };
            if (o.IsPrint)
            {
                Console.WriteLine($"{o.Id} - {o.Note}");
            }
        }
    }
}
