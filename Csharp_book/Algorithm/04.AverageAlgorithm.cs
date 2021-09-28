using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    // n명의 점수 중에서 80점 이상 95점 이하인 점수 평균
    class Class1
    {
        static void Main()
        {
            // 입력 : n명의 성적
            int[] data = { 90, 65, 78, 50, 95 };
            int sum = 0;    // 합계를 담는 그릇
            int count = 0;  // 개수를 담는 그릇

            // 처리 : AVG = SUM / COUNT
            for (int i = 0; i < data.Length; i++)   // 주어진 범위
            {
                if (data[i] >= 80 && data[i] <= 95)
                {
                    sum += data[i]; // SUM
                    count++;    // COUNT
                }
            }

            double avg = 0.0f;
            if (sum != 0 && count != 0) // 예외 처리
            {
                avg = sum / (double)count;
            }

            // 출력
            Console.WriteLine($"80점 이상 95점 이하인 자료 평균 : {avg:0.00}");


            // LINQ로 간단하게 풀기
            var a = (new int[] { 50, 65, 78, 90, 95 }).Where(d => d >= 80 && d <= 95).Average();
            Console.WriteLine(a);
        }
    }
}
