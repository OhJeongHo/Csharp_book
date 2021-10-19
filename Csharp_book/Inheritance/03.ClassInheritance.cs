using System;

namespace Classinheritance
{
    // a. 모든 클래스는 Object 클래스에서 상속
    public class ParentClass : Object
    {
        protected void Print1() => Console.WriteLine("부모 클래스에서 정의한 내용");
    }

    // b. 콜론 기호로 부모 클래스 지정
    public class ChildClass : ParentClass
    {
        public void Print2() => base.Print1();  // c. 자식에서 base 키워드로 부모 요소에 접근
    }

    class ClassInheritance : Object
    {
        static void Main()
        {
            // 1. 부모 ㅋ클래스의 인스턴스 생성
            ParentClass p = new ParentClass();
            Console.WriteLine(p.ToString());

            // 2. 자식 클래스의 인스턴스 생성
            ChildClass c = new ChildClass();
            // Print1() 메소드는 protected로 설정되어있어 외부에서 접근 불가
            // c.Print1();

            c.Print2(); // 자식 클래스에 직접 구현한 기능
        }
    }
}
