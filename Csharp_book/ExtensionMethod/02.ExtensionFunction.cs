using System;

// 확장 메소드로 문자열 기능 확장하기

static class ExtensionFunction
{
    // static 클래스 내 static 메소드의 첫 번째 매개변수에 this가 붙은 것은 확장 메소드
    static string Three(this string value)
    {
        // 특정 문자열 뒤에 이 메소드가 호출되면 문자열 중 3개만 반환
        return value.Substring(0, 3);
    }

    static void Main()
    {
        Console.WriteLine("안녕하세요.".Three());
    }
}
