using System;

namespace Class
{
    class ClassNote
    {
        static void Run()
        {
            Console.WriteLine("ClassNote 클래스의 Run 메소드");
        }

        static void Main()
        {
            Run();              // 메소드 레벨 : 같은 클래스의 메소드 호출
            ClassNote.Run();    // 클래스 레벨 : 클래스.메소드(); 형태로 호출
        }
    }
}
