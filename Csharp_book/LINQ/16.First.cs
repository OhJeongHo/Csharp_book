using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 하나 이상의 데이터 중에서 첫번째 데이터를 가져옴. 컬렉션의 첫번째 요소.
// First() : 요소 없으면 에러 발생
// FirstOrDefault() : 요소가 없으면 기본값을 반환

namespace LINQ
{
    class Class1
    {
        static void Main()
        {
            List<string> colors = new List<string> { "Red", "Green", "Blue" };
            var first = colors.First(c => c == "Red");
            Console.WriteLine(first);

            var first2 = colors.First(c => c == "Blue");
            Console.WriteLine(first2);

            // 없는 데이터를 요청하면 예외 발생
            // var first3 = colors.First(c => c == "Black");

            var first3 = colors.FirstOrDefault(color => color == "Black");
            Console.WriteLine(first3);
        }
    }
}
