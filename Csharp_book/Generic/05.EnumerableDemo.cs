using System;
using System.Collections.Generic;
using System.Linq;

// System.Linq 네임스페이스에 들어있는 Enumerable 클래스는 Range()와 Repeat() 메소드를 제공.
// 특정 범위의 정수 컬렉션을 손쉽게 만들 수 있다.

namespace Generic
{
    class Class1
    {
        static void Main()
        {
            var numbers = Enumerable.Range(1, 5); // 1부터 5까지 정수 컬렉션 생성
            foreach (var n in numbers)
            {
                Console.Write("{0}\t", n);
            }
            Console.WriteLine();

            var sameNumbers = Enumerable.Repeat(-1, 5); // -1을 5개 가진 컬렉션 생성
            foreach (var n in sameNumbers)
            {
                Console.Write("{0}\t", n);
            }
            Console.WriteLine();

            var str = string.Join(",", Enumerable.Range(1, 5)); // string.Join()메소드를 통해서 콤마 포함된 배열 생성

            // 1부터 100까지 정수 중 짝수를 구하고 거꾸로 정렬한 후 10개를 제외하고 5개를 가져옴.
            Enumerable.Range(1, 100).Where(i => i % 2 == 0).Reverse().Skip(10).Take(5);
        }
    }
}
