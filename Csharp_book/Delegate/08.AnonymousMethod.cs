using System;

namespace AnonymousMethod
{
    public class Print
    {
        public static void Show(string msg) => Console.WriteLine(msg);
    }

    public class AnonymousMethod
    {
        // 대리자 선언
        public delegate void PrintDelegate(string msg);
        public delegate void SumDelegate(int a, int b);
        static void Main()
        {
            // 1. 메소드 직접 호출
            Print.Show("안녕하세요.");

            // 2. 대리자에 메소드 등록 후 호출
            PrintDelegate pd = new PrintDelegate(Print.Show);
            pd("반갑습니다.");

            // 3. 무명(익명) 메소드로 호출 : delegate 키워드로 무명 메소드 생성
            PrintDelegate am = delegate (string msg)
            {
                Console.WriteLine(msg);
            };
            am("또 만나요.");

            // 4. 무명 메소드 생성 및 호출
            SumDelegate sd = delegate (int a, int b)
            {
                Console.WriteLine(a + b);
            };
            sd(3, 5);
        }
    }
}
