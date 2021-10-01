using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    // 선택 정렬 알고리즘 : 순서대로 정렬
    class Class1
    {
        static void Main()
        {
            // 입력 : Data Structure(Array, List, Stack, Queue, Tree, DB, ...)
            int[] data = { 3, 2, 1, 5, 4 };
            int N = data.Length;

            // 처리 : 선택 정렬 알고리즘
            for (int i = 0; i < N - 1; i++) // i = 0 to N
            {
                for (int j = i + 1; j < N; j++) // j = i + 1 to N
                {
                    if (data[i] > data[j])  // 부등호 방향 : 오름차순(>), 내림차순(<)
                    {
                        // SWAP
                        int temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }

            // 출력 : Console, Desktop, Web, Mobile, ...
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{data[i]}\t");
            }
            Console.WriteLine();

            // 링큐로 데이터 정렬하기
            // 정렬 알고리즘을 for문과 if문이 아닌 Linq와 람다식으로 할 때는 다음과 같이 Array.Sort() 또는 OrderBy() 사용
            int[] data2 = { 3, 2, 1, 5, 4 };
            Array.Sort(data2);
            for (int i = 0; i < data2.Length; i++)
            {
                Console.Write($"{data2[i]}\t");
            }
            Console.WriteLine();

            int[] data3 = { 3, 2, 1, 5, 4 };
            var sort = data.OrderBy(n => n).ToArray();
            for (int i = 0; i < sort.Length; i++)
            {
                Console.Write($"{sort[i]}\t");
            }
            Console.WriteLine();
        }
    }
}
