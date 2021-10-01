using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 병합 알고리즘은 배열 2개를 합쳐서 하나로 만든다.
 * first 배열은 1 ~ M,
 * Secone 배열은 1 ~ N 자료가 있음.
 * i, j, k는 배열 첨자 변수로 사용.
 */

namespace Algorithm
{
    class Class1
    {
        static void Main()
        {
            // 입력
            int[] first = { 1, 3, 5 };  // 오름차순 정렬 됨
            int[] second = { 2, 4 };    // 오름차순 정렬 됨
            // M:N 관행
            int M = first.Length;
            int N = second.Length;
            int[] merge = new int[M + N];
            // i, j, k 관행
            int i = 0;
            int j = 0;
            int k = 0;

            // 처리
            while (i < M && j < N) // 둘 중 하나라도 배열 끝에 도달할 때 까지
            {
                if (first[i] <= second[j])  // 작은 값을 merge배열에 저장
                {
                    merge[k++] = first[i++];
                }
                else
                {
                    merge[k++] = second[j++];
                }
            }
            while (i < M)   // 첫번째 배열이 끝에 도달할 때 까지
            {
                merge[k++] = first[i++];
            }
            while (j < N)   // 두번째 배열이 끝에 도달할 때 까지
            {
                merge[k++] = second[j++];
            }

            // 출력
            foreach (var m in merge)
            {
                Console.Write($"{m}\t");
            }
            Console.WriteLine();


            // 링큐로 데이터 병합하기
            int[] first2 = { 1, 3, 5 };
            int[] second2 = { 2, 4 };
            int[] merge2 = (from o in first2 select o).Union(from t in second2 select t).OrderBy(m => m).ToArray();
            foreach (var item in merge2)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            int[] merge3 = first2.Union(second2).OrderBy(m => m).ToArray();
            foreach (var item in merge3)
            {
                Console.Write($"{item}\t");
            }
        }
    }
}
