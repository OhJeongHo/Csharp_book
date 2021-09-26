using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 데이터를 오름차순으로 정렬할 땐 OrderBy()
// 데이터를 내림차순으로 정렬할 땐 OrderByDescending() 메소드 사용

namespace LINQ
{
    class Class1
    {
        static void Main()
        {
            // OrderBy() 메소드를 통해서 ABC/가나다 순서로 정렬 가능.
            string[] colors = { "Red", "Green", "Blue" };
            // 선언시 var를 사용하는 것이 더 좋다.
            IEnumerable<string> sortedColors = colors.OrderBy(name => name);
            foreach (var color in sortedColors)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine();

            // OrderByDescending() 메소드로 내림차순 정렬하기
            var colors2 = new List<string> { "Red", "Blue", "Green" };
            var sortedColors2 = colors.OrderByDescending(c => c);
            foreach (var color in sortedColors2)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine();

            // 확장 메소드 체이닝
            List<string> names = new List<string> { ".NET", "C#", "TypeScript" };
            var results = names.Where(name => name.Length > 2).OrderBy(n => n);
            // 길이가 2 이상인 것들만 뽑아서 오름차순으로 정렬.
            foreach (var name in results)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            // 짝수인 데이터만 오름차순으로 정렬하기
            var numbers = Enumerable.Range(1, 10);
            foreach (var item in numbers)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            var selected = numbers.Where(n => n % 2 == 0).OrderBy(n => n);
            foreach (var item in selected)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            // 짝수인 데이터만 내림차순 정렬
            var numbers2 = Enumerable.Range(11, 10);
            foreach (var item in numbers2)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            var selected2 = numbers.Where(n => n % 2 == 0).OrderByDescending(n => n);
            foreach (var item in selected2)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            // 특정 문자열을 포함하는 컬렉션 가져오기
            var color3 = new List<string> { "Red", "Green", "Blue" };
            var newColors = color3.Where(c => c.Contains("e"));
            foreach (var color in newColors)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine();

            var green = color3.Where(c => c.Contains("ee"));
            foreach (var c in green)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();


            // 대소문자 구분하지 않고 검색하기.
            // Contains()는 일반적으로 대소문자를 구분한다.
            List<string> names2 = new List<string> { "ASP.NET", "Blazor", "C#" };
            var answer1 = names2.Where(n => n.Contains("a"));
            foreach (var item in answer1)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            var answer2 = names2.Where(n => n.Contains("A"));
            foreach (var item in answer2)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            var answer3 = names2.Where(n => n.ToUpper().Contains("A"));
            foreach (var item in answer3)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }
    }
}
