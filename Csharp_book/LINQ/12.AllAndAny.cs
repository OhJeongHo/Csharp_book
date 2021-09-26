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
            // All() 메소드와 Any()메소드는 컬렉션에서 모든 조건을 만족하거나 하나의 조건이라도 만족하는 경우를 판단.

            bool[] completes = { true, true, true };
            Console.WriteLine(completes.All(c => c == true));

            bool[] completes2 = { true, false, true };
            Console.WriteLine(completes2.Any(c => c == false));


            // Any() 확장 메소드로 데이터가 있는지 확인하기
            int[] arr = { 1, 2, 3 };
            bool bln = arr.Any(num => num == 2);    // bool값 반환
            Console.WriteLine(bln);
            // 원소중에 하나라도 2가 있다면 true;
            // arr.Any() 형태로 요청하면 데이터가 있는지 확인할 수 있고,
            // arr.Any(람다식) 형태로 요청하면 람다식 조건에 맞는 데이터가 있는지 확인할 수 있다.

        }
    }
}
