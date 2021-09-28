using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Class1
    {
        // n명의 국어 점수 중에서 80점 이상인 점수의 합
        static void Main()
        {
            // 입력 : n명의 국어 점수 입력
            int[] scores = { 100, 75, 50, 37, 90, 95 };
            int sum = 0;

            // c처리 : 합계 알고리즘 영역 : 주어진 범위에 주어진 조건(필터링)
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] >= 80)
                {
                    sum += scores[i]; //SUM
                }
            }

            // 출력
            Console.WriteLine($"{scores.Length}명의 점수 중 80점 이상 총점 : {sum}");

            // 합계 알고리즘을 LINQ로 구현
            var a = (new int[] { 100, 75, 50, 37, 90, 95 }).Where(s => s >= 80).Sum();
            Console.WriteLine(a);
        }
    }
}
