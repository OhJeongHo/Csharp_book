using System;
using System.Collections;

namespace Collection
{
    class Class1
    {
        static void Main()
        {
            Stack stack = new Stack();  // Stack 클래스의 인스턴스 생성

            stack.Push("첫 번째"); // 데이터 입력
            stack.Push("두 번째");
            stack.Push("세 번째");

            Console.WriteLine(stack.Pop()); // 데이터 출력 : 세번째
            Console.WriteLine(stack.Pop()); // 데이터 출력 : 두번째
            Console.WriteLine(stack.Pop()); // 데이터 출력 : 첫번째

            // 비어있는 스택에서 Pop() 요청하면 에러
            try
            {
                Console.WriteLine(stack.Pop()); // 언더플로 에러
            }
            catch(Exception ex)
            {
                Console.WriteLine($"예외 내용 : {ex.Message}");
            }
        }
    }
}
