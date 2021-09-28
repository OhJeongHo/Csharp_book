using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Class1
    {
        // 원본 데이터 중에서 대상 데이터와 가장 가까운 값 : 근사값 찾기
        static void Main()
        {
            // 절대값 구하기 로컬 함수 : Math.Abs() 함수와 동일한 기능을 구현해 봄.
            int Abs(int number) => (number < 0) ? -number : number;
            // int 값을 리턴하고 int를 매개변수로 받는 함수 : 입력 값이 0보다 작으면 -를 붙여줌.

            // 초기화
            int min = int.MaxValue; // 차이 값이 절댓값 중 최솟값이 담길 그릇

            // 입력 : 이진수 와 16진수로 표현({ 10, 20, 30, 27, 17 });
            int[] numbers = { 0b1010, 0x14, 0b11110, 0x1B, 0b10001 };
            int target = 25;    // target과 가까운 값
            int near = default; // 가까운 값 : 27

            // 처리 : NEAR
            for (int i = 0; i < numbers.Length; i++)
            {
                int abs = Abs(numbers[i] - target); // 차이의 절대값.
                if (abs < min)
                {
                    min = abs;  // MIN 최솟값 알고리즘
                    near = numbers[i];  // 차이 값의 절대값 중 최솟값일 때 값.
                }
            }

            // 출력
            var minimum = numbers.Min(m => Math.Abs(m - target));
            var closest = numbers.First(c => Math.Abs(target - c) == minimum);

            Console.WriteLine($"{target}와/과 가장 가까운 값(식) : {closest}(차이 : {minimum})");
            Console.WriteLine($"{target}와/과 가장 가까운 값(문) : {near}(차이 : {min})");
        }
    }
}
