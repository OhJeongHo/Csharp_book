using System;


namespace Exception_handling
{
    class Class1
    {
        static void Main()
        {
            Console.WriteLine("[1] 시작");

            try
            {
                Console.WriteLine("[2] 실행");
                throw new Exception();  // 무작정 에러 발생
            }
            finally // 예외가 발생하든 하지 않든 간에 실행(마무리 영역)
            {
                Console.WriteLine("[3] 종료");
            }
        }
    }
}
