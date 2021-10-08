using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 날짜 형태의 문자열을 진짜 날짜형으로 변환하는 방법
// 모든 기본 형식이 가지고 있는 TryParse() 메소드를 사용.
// 자료형.TryParse("반환할 내용", out "반환이 되면 담을 그릇")

namespace Method
{
    class Class1
    {
        static void Main()
        {
            DateTime dt;    // 1. 반환형 매개변수에 사용될 지역 변수(초기화하지 않음)

            // 2. DateTime.TryParse()로 날짜 형식으로 변환 시도(변환 가능하면 dt에 저장)
            if (DateTime.TryParse("2020-01-01",out dt))
            {
                Console.WriteLine(dt);
            }
            else
            {
                Console.WriteLine("날짜 형식으로 변환할 수 없습니다.");
            }

            // TryParse() 메소드에 지역 변수 선언과 동시에 초기화 가능
            if (DateTime.TryParse("2020-01-01", out var myDate))
            {
                Console.WriteLine(myDate);
            }
        }
    }
}
