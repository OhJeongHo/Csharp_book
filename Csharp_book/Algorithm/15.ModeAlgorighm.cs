using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 최반값 은 데이터 중에서 가장 많이 나타나는 값을 의미함.
 * 데이터 자체를 배열의 인덱스로 보고, 인덱스 개수 알고리즘을 적용하는 형태.
 * 
 * 데이터에 해당하는 인덱스를 1씩 증가시켜 최종적으로 가장 높은 값인 인덱스를 찾는 것.
 * 점수 인덱스 개수의 최댓값.
 */

namespace Algorithm
{
    class Class1
    {
        static void Main()
        {
            //입력 : 점수는 0부터 N까지 들어온다고 가정
            int[] scores = { 1, 3, 4, 3, 5 };   // 0 ~ 5만 들어온다고 가정
            int[] indexes = new int[5 + 1];     // 0 ~ 5의 점수 인덱스 개수 저장
            int max = int.MinValue; // MAX 알고리즘 적용
            int mode = 0;   // 최빈값이 담길 그릇

            // 처리 : Data -> Index -> Count -> Max -> Mode
            for (int i = 0; i < scores.Length; i++)
            {
                indexes[scores[i]]++;   // Count
            }
            for (int i = 0; i < indexes.Length; i++)
            {
                if (indexes[i] > max)
                {
                    max = indexes[i];   // Max
                    mode = i;
                }
            }

            // 출력
            Console.WriteLine($"최빈값(문) : {mode} -> {max}번 나타남");
            var q = scores.GroupBy(v => v).OrderByDescending(g => g.Count()).First();
            int modeCount = q.Count();
            int frequency = q.Key;
            Console.WriteLine($"최빈값(식) : {frequency} -> {modeCount}번 나타남");
        }
    }
}
