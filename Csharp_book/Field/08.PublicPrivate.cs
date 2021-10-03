using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TestClass
{
    private static string name = "백승수"; // private(비공개)
    public static string siteName = "길벗";   // public 필드는 권장하지 않음.

    public static string GetName()
    {
        return name;
    }
}

class PublicPrivate
{
    static void Main()
    {
        // TestClass.name; => private 맴버는 외부에 노출되지 않음.
        Console.WriteLine(TestClass.siteName);  // public 멤버는 외부에 노출

        // private 필드 값을 외부에 공개할 떄는 public 으로 공개
        Console.WriteLine(TestClass.GetName());
    }
}
