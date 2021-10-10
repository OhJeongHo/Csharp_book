using System;
using System.Collections.Generic;

// 배열에 저장된 값 중에서 특정 값보다 큰 데이터만 가져올 때
// yield return 사용과 사용하지 않은 코드 비교.
// yield return을 사용하면 추가적인 List<T> 형태의 컬렉션 클래스가 없이도 구현 가능.

class Test
{
    // 1. yield 사용 전 : List<T> 형태의 컬렉션 클래스를 임시로 사용하여 결과값 저장 후 반환
    static IEnumerable<int> Greater1(int[] numbers, int greater)
    {
        List<int> temp = new List<int>();
        foreach (var n in numbers)
        {
            if (n > greater)
            {
                temp.Add(n);
            }
        }
        return temp;
    }

    // 2. yield 사용 후 : 추가 클래스 사용 없이 여러 데이터를 yield return으로 반환
    static IEnumerable<int> Greater2(int[] numbers, int greater)
    {
        foreach (var n in numbers)
        {
            if (n > greater)
            {
                yield return n;
            }
        }
    }

    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (var n in Greater1(numbers, 3))
        {
            Console.WriteLine(n);
        }

        foreach (var n in Greater2(numbers, 3))
        {
            Console.WriteLine(n);
        }
    }
}