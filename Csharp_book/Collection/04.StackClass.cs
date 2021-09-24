using System;
using System.Collections;

namespace Collection
{
    class Class1
    {
        /*
         * Stack 클래스는 아래에서 위로 데이터를 쌓는 형태의 자료구조.
         * LIFO(후입선출) 특성을 보임 => 나중에 들어온 데이터가 먼저 출력되는 자료 구조.
         * 
         * Count : 스택에 있는 데이터 개수 조회
         * Push() : 스택에 데이터 저장
         * Pop() : 스택에서 데이터 꺼내기
         * 
         * 스택 클래스를 사용하려면 System.Collections 네임스페이스를 포함해야함.
         */

        static void Main()
        {
            Stack stack = new Stack();
            // 스택 클래스는 Push() 메소드로 object 형식의 데이터를 저장할 수 있다.
            stack.Push("First");
            stack.Push("Second");

            // 스택 클래스에 저장된 데이터는 Pop() 메소드로 읽어올 수 있다.
            // 이때 나중에 입력된 데이터가 먼저 출력됨.
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            // 스택에 저장된 데이터가 아무것도 없는데 Pop() 메소드를 사용하면 다음과 같이 에러가 발생함.
            stack.Pop();
        }
    }
}
