using System;
using System.Collections;

// 닷넷에 내장된 IEnumerator 인터페이스 사용

class IEnumeratorDemo
{
    static void Main()
    {
        string[] names = { "닷넷코리아", "비주얼아카데미" };

        // 1. foreach 문으로 출력
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // 2. IEnumerator 인터페이스를 사용한 데이터 출력 : foreach 문과 동일
        IEnumerator list = names.GetEnumerator();   // 하나씩 열거
        while (list.MoveNext()) // 값이 있는 동안 반복
        {
            Console.WriteLine(list.Current);    // 현재 반복 중인 데이터 출력
        }
    }
}

/*
 * IEnumerator 인터페이스는 문자열 배열 등 GetEnumerator() 메소드의 결괏값을 담아 MoveNext() 메소드로 값이 있는지 확인하고,
 * Current 속성으로 현재 반복되는 데이터를 가져다 사용할 수 있다.
 */