using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// null 가능 형식 : Nullable<T> 형식
// bool과 Nullable<bool>의 차이점 => bool은 true/false, Nullable<bool>은 true/false/null
// Nullable<T> 형식을 줄여서 표현하는 방법은 데이터 형식 뒤에 ?기호를 붙이면 된다.
// 해당 형식이 제공하는 주요 맴버들.
// HasValue - 값이 있으면 true, null이면 false를 반환
// Value - 값 반환
// GetValueOrDefault - 값 또는 기본값 반환

namespace nullDemo
{
    class Class1
    {
        static void Main()
        {
            string s = null;    // 참조형식 : null 할당 가능
            Console.WriteLine(s);

            //int i = null;   // 값 형식 : null 불가능 -> 에러 발생

            int? i = null;
            Console.WriteLine(i);

            double? d = null;
            Console.WriteLine(d);

            // System.Nullable<T> 제네릭 클래스 : int?, double? 사용을 권장함.
            Nullable<int> ii = null;
            //int? ii = null;

            Nullable<double> dd = null;
            // double? dd = null;

        }
    }
}
