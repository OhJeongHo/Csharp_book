using System;

// C# 파일 하나에 클래스 여러개 만들기

class MyClass
{
    public static void MyMethod()
    {
        Console.WriteLine("클래스");
    }
}

class ClassDescription
{
    static void Main()
    {
        MyClass.MyMethod();
    }
}
