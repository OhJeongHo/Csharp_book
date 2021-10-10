using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// IEnumerable<T> 형태는 내부적으로 MoveNext() 메소드와 Current 속성을 함께 사용함.

namespace Indexer
{
    class Class1
    {
        static void Main()
        {
            // 정수 3개를 반환하는 GetNumbers() 함수 생성
            IEnumerable<int> GetNumbers()
            {
                yield return 1;
                yield return 3;
                yield return 5;
            }

            var nums = GetNumbers().GetEnumerator();
            Console.WriteLine(nums);

            // MoveNext() 메소드 호출하면 데이터를 하나씩 선택한 후 Current 속성으로 현재 값을 가져옴.
            nums.MoveNext();    // 해당 메소드의 결과는 다음 값이 있으면 true를 반환하고 없으면 false를 반환
            Console.WriteLine(nums.Current);
            nums.MoveNext();
            Console.WriteLine(nums.Current);
        }


    }
}
