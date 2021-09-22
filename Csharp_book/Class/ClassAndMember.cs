using System;

public class ClassName
{
    public static void MemberName()
    {
        Console.WriteLine("클래스의 맴버가 호출되어 실행됩니다.");
    }
}
class ClassAndMember
{
    public static void Main()
    {
        ClassName.MemberName();
    }
}

