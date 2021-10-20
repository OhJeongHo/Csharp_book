using System;


namespace ExtensionMethod
{
    public static class MyClass
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }

    class ExtensionMethodDemo
    {
        static void Main()
        {
            string s = "안녕하세요? 확장 메소드... ...";
            Console.WriteLine(s.Length);    // 1. 문자 개수
            Console.WriteLine(s.WordCount());   // 2. 단어 개수
        }
    }
}
