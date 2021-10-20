using System;

// 확장 메소드를 사용하여 형식에 메소드 추가하기
// Original 클래스는 아무 멤버도 없는 클래스이지만, 확장해서 메소드를 추가하여 사용 가능.

public class Original { /* Empty */ };

public static class originalExtension
{
    public static void NewMethod(this Original original) => Console.WriteLine("새로운 메소드 추가");
}

class ExtensionMethodNote
{
    static void Main()
    {
        (new Original()).NewMethod(); // 확장 메소드 호출
    }
}