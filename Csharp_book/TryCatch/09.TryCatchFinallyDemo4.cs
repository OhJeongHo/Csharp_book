﻿using System;
using static System.Console;

namespace Exception_handling
{
    class Class1
    {
        static void Main()
        {
            int x = 5;
            int y = 0;
            int r;

            try // 예외가 발생할 만한 구문이 들어오는 곳
            {
                r = x / y;
                WriteLine($"{x} / {y} = {r}");
            }
            catch (Exception ex)
            {
                WriteLine($"예외 발생 : {ex.Message}");
            }
            finally
            {
                WriteLine("프로그램을 종료합니다.");
            }
        }
    }
}
