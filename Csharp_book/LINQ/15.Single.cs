using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 컬렉션에서 조건에 맞는 값을 단 하나만 가져오는 확장 메소드는 Single()과 SingleOrDefault()가 있다.
// Single() : null 값이면 예외가 발생 - 즉 에러 발생
// SingleOrDefault()    :   값이 없으면 null 값을 반환

namespace LINQ
{
    class Class1
    {
        static void Main()
        {
            List<string> colors = new List<string> { "Red", "Green", "Blue" };
            string red = colors.Single(c => c == "Red");
            Console.WriteLine(red);


            // 없는 데이터를 요청하면 예외 발생
            //string black = colors.Single(color => color == "Black");

            // 없는 데이터를 요청하는 null 값 반환
            string black = colors.SingleOrDefault(color => color == "Black");
            Console.WriteLine(black);
        }
    }
}
