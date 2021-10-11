// 대리자를 사용하여 메소드 여러 개 다중 호출하기

using System;

namespace DelegatePractice
{
    public class CarDriver
    {
        public static void GoForward() => Console.WriteLine("직진");
        public static void GoLeft() => Console.WriteLine("좌회전");
        public static void GoRight() => Console.WriteLine("우회전");
    }

    public class Insa
    {
        public void Bye() => Console.WriteLine("잘가");
    }

    // 대리자 생성 : 의미상으로 대리운전, class 같은 레벨로 생성해도 됨
    public delegate void GoHome();

    public class DelegatePractice
    {
        // 대리자 형식 선언 : 메소드를 묶을 별칭, 클래스 내부에도 생성 가능
        public delegate void Say();

        private static void Hello() { Console.WriteLine("Hello"); }
        private static void Hi() { Console.WriteLine("Hi"); }

        static void Main(string[] args)
        {
            // 1. 메소드는 따로따로 호출
            CarDriver.GoLeft();
            CarDriver.GoForward();
            CarDriver.GoRight();

            // 2. 대리자를 사용한 메소드 등록 및 호출
            GoHome go = new GoHome(CarDriver.GoLeft);
            go += new GoHome(CarDriver.GoForward);
            go += new GoHome(CarDriver.GoRight);
            go += new GoHome(CarDriver.GoLeft); // 등록
            go -= new GoHome(CarDriver.GoLeft);  // 취소
            go();   // 집에 갑시다... 한 번 호출

            Console.WriteLine();

            // 3. 대리자를 사용하여 한 번에 메소드 2개 호출...
            Say say;    // a. 대리자 형식 변수 선언
            say = new Say(Hi);  // b. Hi 메소드 지정
            say += new Say(Hello);  // c. Hello 메소드 지정
            say();  // d. 대리자로 메소드 2개 호출

            // 4. 대리자를 사용하여 호출
            Insa insa = new Insa();
            Say say2 = new Say(insa.Bye);
            say2 += new Say(insa.Bye);
            say2();
        }
    }
}
