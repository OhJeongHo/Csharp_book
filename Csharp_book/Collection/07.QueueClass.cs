using System;
using System.Collections;

namespace Collection
{
    class Class1
    {
        /*
         * Queue 클래스는 먼저 들어온 데이터가 먼저 나온다.
         * 큐라는 단어는 기다림 통로 또는 FIFO(선입선출)로 표현되며, 먼저 들어온 것이 먼저 나가는 형태의 데이터.
         */

        static void Main()
        {
            var queue = new Queue(); // 큐 클래스의 인스턴스 생성

            queue.Enqueue(10);  // 큐(대기 행렬)에 데이터 입력 : Enqueue()
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine(queue.Dequeue());    // 큐에서 데이터 출력 : Dequeue()
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            Console.WriteLine(queue.Dequeue());     // 큐가 비어있는 경우 에러 발생
        }
    }
}
