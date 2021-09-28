using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Class1
    {
        // 주어진 데이터 중에서 가장 큰 값
        static void Main()
        {
            // 초기화
            int max = int.MinValue; // 정수 형식의 데이터 중 가장 작은 값으로 초기화

            // 입력
            int[] numbers = { -2, -5, -3, -7, -1 };

            // 처리 : MAX
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i]; // MAX : 더 큰 값으로 할당
                }
            }

            // 출력
            Console.WriteLine($"최댓값(식) : {numbers.Max()}"); // 링큐의 Max() 확장 메소드
            Console.WriteLine($"최댓값(문) : {max}");
        }
    }
}
