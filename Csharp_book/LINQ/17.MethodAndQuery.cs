using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 링큐는 쿼리 구문도 제공함.
// 메소드 구문 : Where() 같은 메소드를 사용해서 컬렉션을 다루는 방법
// 쿼리 구문 : from, where, select 같은 키워드를 사용하여 쿼리 형태로 컬렉션을 다루는 방법

namespace LINQ
{
    class Class1
    {
        static void Main()
        {
            var numbers = Enumerable.Range(1, 10);

            // 짝수 데이터만 가져와서 내림차순으로 정렬하기.
            // 메서드 구문 사용하기
            var method = numbers.Where(n => n % 2 == 0).OrderByDescending(n => n);

            // 쿼리 구문 사용하기
            var query = from n in numbers where n % 2 == 0 orderby n descending select n;

            foreach (var item in method)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            foreach (var item in query)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            // 쿼리 구문과 메소드 구문을 함께 사용할 수도 있다.
            var sum = (from n in numbers where n % 2 == 0 select n).Sum();
            var count = (from n in numbers where n % 2 == 0 select n).Count();
            var average = (from n in numbers where n % 2 == 0 select n).Average();
            var max = (from n in numbers where n % 2 == 0 select n).Max();
            var min = (from n in numbers where n % 2 == 0 select n).Min();


            // 쿼리문은 여러줄에 걸쳐서 작성할 수 있다.
            int[] arr = { 1, 2, 3, 4, 5 };
            var q =
                from a in arr
                where a % 2 == 0
                select a;
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}
