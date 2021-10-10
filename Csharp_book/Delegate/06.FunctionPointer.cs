using System;

// 대리자 형식은 함수 포인터라고도 함.
// 대리자를 생성할 때 사용되는 delegate 키워드는 이름이 없는 메소드(무명 메소드)를 만들 때도 함께 사용됨.

namespace Delegate
{
    class Class1
    {
        public delegate void Whats();   // 1. 함수 포인터 형식

        // 강력한 형식의 대리자
        // Math.Pow() 메소드를 대신 호출하는 DelegateType 이름의 대리자 사용

        public delegate double DelegateType(double x, double y);

        static void Main()
        {
            // 2. 함수 포인터 정의
            Whats whats = delegate { Console.WriteLine("함수 포인터 == 대리자"); };

            DelegateType pow = Math.Pow;
            double actual = pow(2, 10);


            whats();    // 3. 함수 포인터 호출
            Console.WriteLine(actual);
        }
    }
}
