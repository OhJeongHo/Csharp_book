using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Class1
    {
        static void Main()
        {
            var data = Enumerable.Range(0, 100);    // 0 ~ 99
            var first = data.Take(5);   // 앞에서 5개
            foreach (var item in first)
            {
                Console.WriteLine(item);
            }
            
            var second = data.Where(n => n %2 == 0).Take(5);  // 짝수중에서 앞에서 5개
            foreach (var item in second)
            {
                Console.WriteLine(item);
            }


            // Skip 메소드는 지정한 수만큼 데이터를 제외한 컬렉션을 반환.
            var data2 = Enumerable.Range(0, 100);
            var next = data2.Skip(10).Take(5);  // 앞에서부터 10개를 제외하고 다시 앞에서부터 5개 가져오기
            foreach (var item in next)
            {
                Console.WriteLine(item);
            }


            // Distinct() 메소드를 사용하면 컬렉션에서 중복된 데이터를 제거
            var data3 = Enumerable.Repeat(3, 5); // 3을 5개 저장
            var result = data3.Distinct();   // Distinct()로 중복 제거
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            int[] arr = { 2, 2, 3, 3, 3 };  // 2와 3을 중복해서 배열에 저장
            var result2 = arr.Distinct();
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
