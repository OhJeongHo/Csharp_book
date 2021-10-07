using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ParameterRef
{
    static void Main()
    {
        int num = 10;
        Console.WriteLine($"[1] {num}");    // 1

        Do(ref num);    // 참조 전달 방식

        Console.WriteLine($"[3] {num}");    // 3
    }

    static void Do(ref int num) // 참조 전달 방식
    {
        num = 20;   // 호출된 부분에 적용(Main() 메소드의 num 변수 값이 변경됨)
        Console.WriteLine($"[2] {num}");    // 2
    }
}
