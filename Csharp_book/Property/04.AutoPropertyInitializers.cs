using System;


// 자동 속성 이니셜라이저
// 속성을 선언과 동시에 기본값으로 초기화할 수 있다.

class AutoPropertyInitializers
{
    public static string Name { get; set; } = "길벗";

    static void Main()
    {
        Console.WriteLine(Name);
    }
}
