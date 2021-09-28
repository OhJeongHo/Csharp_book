using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Class1
    {
        // 주어진 데이터 중에서 가장 작은 짝수 값
        static void Main()
        {
            // 초기화
            var min = Int32.MaxValue; // 정수 형식 데이터 중 가장 큰 값으로 초기화

            // 입력 : 이진수로 표현 + 숫자 구분자 사용({ 2, 5, 3, 7, 1 })
            int[] numbers = { 0b0010, 0B_0101, 0b0011, 0B_0111, 0b0000_0001 };

            // 처리 : MIN
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min && numbers[i] % 2 == 0)
                {
                    min = numbers[i];
                }
            }

            // 출력
            Console.WriteLine($"짝수 최솟값(식) : {numbers.Where(n => n % 2 == 0).Min()}");   // 링큐로 한번에 하기
            Console.WriteLine($"짝수 최솟값(문) : {min}");
        }
    }
}
