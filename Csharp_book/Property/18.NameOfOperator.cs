using System;

// nameof 를 사용하면 오타를 방지할 수 있다.

class nameOfOperator
{
    static void Main()
    {
        Console.WriteLine("NameToString");
        Console.WriteLine(nameof(NameToString));
    }

    static void NameToString()
    {
        // 프로그래밍할 때 함수 또는 속성의 이름을 다른 곳에 문자열로 넘겨주어야 할 때가 있음.
    }
}
