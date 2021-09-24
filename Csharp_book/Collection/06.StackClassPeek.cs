using System;
using System.Collections;


// Peek() 메소드는 스택 위에 있는 데이터를 가져오지만,
// Pop() 메소드처럼 제거하지는 않는다.
// 스택에 데이터를 넣고 계속해서 사용만 할 떄는 Peek() 메소드를 사용함.
namespace Collection
{
    class Class1
    {
        static void Main()
        {
            Stack stack = new Stack();  // Stack 개체 생성

            stack.Push("닷넷노트"); // Push()로 데이터 저장
            stack.Push("닷넷코리아");
            stack.Push("비주얼아카데미");

            Console.WriteLine($"{stack.Peek()}, {stack.Count}"); // Peek()로 제일 위(마지막) 데이터 반환
            stack.Pop(); // Pop()로 현재 스택의 가장 마지막 데이터 제거
            Console.WriteLine($"{stack.Peek()}, {stack.Count}"); // 스택의 마지막 데이터 반환 : 비어있으면 에러

            if (stack.Count > 0)
            {
                stack.Pop();    // 가장 마지막 데이터 제거
                Console.WriteLine($"{stack.Peek()}, {stack.Count}");
            }

            stack.Clear();
            Console.WriteLine(stack.Count);
        }
    }
}