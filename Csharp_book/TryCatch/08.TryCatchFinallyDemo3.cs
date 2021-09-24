﻿using static System.Console;

namespace Exception_handling
{
    class Class1
    {
        static void Main()
        {
            int x = 5;
            int y = 0;
            int r;

            try // 예외가 발생할만한 구문이 들어오는 곳
            {
                r = x / y;
                WriteLine($"{x} / {y} = {r}");
            }
            catch   // try 절에서 예외가 발생하면 실행
            {
                WriteLine($"예외가 발생했습니다.");
            }
            finally // 예외가 발생하든 하지 않든 간에 실행
            {
                WriteLine("프로그램을 종료합니다.");
            }
        }
    }
}
