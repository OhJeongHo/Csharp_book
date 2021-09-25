using System;
using System.Collections.Generic;

// 일반 클래스인 Stack과 제네릭 Stack<T>이 하는 일이 동일해 보이지만,
// 일반 Stack 클래스는 데이터를 object로 다루기 때문에, 중간 변환과정이 진행된다.
// 제네릭은 중간 변환 과정이 없기 때문에 비용적으로 이점이 있다.
// 값형 데이터를 참조형 데이터로 변환하는 박싱 작업과 그 반대로 참조형 데이터를 값형 데이터로 변환하는 언박싱 작업을 하지 않아 성능 향상.
namespace Generic
{
    class Class1
    {
        static void Main()
        {
            Stack<string> stack = new Stack<string>(); // 문자열만 다룰 수 있는 Stack 클래스 생성

            stack.Push("First");    // 문자열 입력
            Console.WriteLine(stack.Pop());
        }
    }
}
