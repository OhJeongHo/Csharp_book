using System;


namespace nullDemo
{
    class Class1
    {
        static void Main()
        {
            int i = 0;  // 값 형식
            string s = null;    // 참조 형식
            s = "안녕하세요";
            string empty = ""; // 빈값은 null과는 다름.

            Console.WriteLine(i);
            Console.WriteLine(s);
            Console.WriteLine(empty);
        }
    }
}
