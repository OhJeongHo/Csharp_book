using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Class1
    {
        // 1부터 1000까지 정수 중 13의 배수 개수
        static void Main()
        {
            // 입력 : 1부터 1000까지 데이터/ 아래와 같은 방식으로 배열을 만들수도 있다.
            var numbers = Enumerable.Range(1, 1_000).ToArray();
            int count = default; // 개수를 저장할 변수는 0으로 초기화

            // 처리 : 개수 알고리즘 영역 : 주어진 범위에 주어진 조건(필터링)
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 13 == 0)
                {
                    count++; // COUNT
                }
            }

            // 출력
            Console.WriteLine($"1부터 1000까지 정수 중 13의 배수 개수 : {count}");


            // LINQ를 사용하여 간단히 표현
            var a = Enumerable.Range(1, 1000).Count(n => n % 13 == 0);
            Console.WriteLine(a);
        }
    }
}
