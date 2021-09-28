using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Class1
    {
        // 가까운 값 모두 구하기
        static void Main()
        {
            int[] data = { 10, 20, 23, 27, 17 };
            int target = 25;
            List<int> nears = new List<int>();
            int min = Int32.MaxValue;

            // MIN 알고리즘 : 차이의 최솟값 구하기
            for (int i = 0; i < data.Length; i++)
            {
                if (Math.Abs(data[i] - target) < min)
                {
                    min = Math.Abs(data[i] - target);
                }
            }
            Console.WriteLine($"차이의 최솟값 : {min}");

            // NEAR 알고리즘 : 차이의 최솟값이 min인 값들을 다시 한 번 비교
            for (int i = 0; i < data.Length; i++)
            {
                if (Math.Abs(data[i]-target) == min)
                {
                    nears.Add(data[i]);
                }
            }

            // 가장 가까운 값 출력
            foreach (var n in nears)
            {
                Console.WriteLine(n);
            }
        }
    }
}
