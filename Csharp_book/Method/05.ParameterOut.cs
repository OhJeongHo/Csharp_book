using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 반환형 매개변수 전달 방식
// 메소드를 호출하기 전에 굳이 지역변수를 초기화하지 않고 호출한 메소드에서 전달한 값을 사용해야 할 때가 있다.

class ParameterOut
{
    static void Main()
    {
        int num;    // 변수를 반드시 초기화할 필요는 없음

        Do(out num);    // 반환형 매개변수 전달 방식

        Console.WriteLine($"[2] {num}");
    }

    static void Do(out int num)
    {
        num = 1234; // b. ref와 동일 : 호출한 부분에 적용, 반드시 초기화해야 함
        Console.WriteLine($"[1] {num}");    // 1. 1234
    }
}