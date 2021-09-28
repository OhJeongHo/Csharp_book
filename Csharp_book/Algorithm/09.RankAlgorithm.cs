using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Class1
    {
        // 순위 알고리즘
        static void Main()
        {
            // 입력
            int[] scores = { 90, 87, 100, 95, 80 };
            int[] rankings = Enumerable.Repeat(1, 5).ToArray(); // 모두 1로 초기화

            // 처리
            for (int i = 0; i < scores.Length; i++)
            {
                rankings[i] = 1;    // 1등으로 초기화, 순위 배열을 매 회전마다 1등으로 초기화

                for (int j = 0; j < scores.Length; j++)
                {
                    if (scores[i] < scores[j])
                    {
                        rankings[i]++;  // 나보다 큰 점수가 나오면 순위 1 증가
                    }
                }
            }

            // 출력
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"{scores[i],3}점 : {rankings[i]}등");
            }


            // LINQ와 람다식으로 표현
            int[] nums = { 90, 87, 100, 95, 80 };
            var rank = nums.Select(s => nums.Where(ss => ss > s).Count() + 1).ToArray();
            foreach (var item in rank)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            var rank2 = nums.Select(s => new { Score = s, Rank = nums.Where(ss => ss > s).Count() + 1 });
            foreach (var r in rank2)
            {
                Console.WriteLine($"{r.Score,3} - {r.Rank}");
            }
        }
    }
}
