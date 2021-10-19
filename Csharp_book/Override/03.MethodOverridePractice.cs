using System;

// 메소드의 이름이 동일할 때 부모 또는 자식 클래스의 멤버에 접근하는 방법

namespace MethodOverridePractice
{
    public class ParentClass
    {
        public virtual void Hi1() => Console.WriteLine("기본 : 안녕하세요.");
        public void Hi2() => Console.WriteLine("기본 : 반갑습니다.");
        public void Hi3() => Console.WriteLine("기본 : 또 만나요");
    }

    public class ChildClass : ParentClass
    {
        public override void Hi1() => Console.WriteLine("파생 : 안녕하세요.");
        public new void Hi2() => Console.WriteLine("파생 : 반갑습니다.");
        public new void Hi3() => base.Hi3();    // 기본 클래스의 멤버에 접근
    }

    class Parent
    {
        public void Say() => Console.WriteLine("부모가 말하다.");
        public void Hi() => Console.WriteLine("부모가 인사하다.");
        public virtual void Walk() => Console.WriteLine("부모가 걷다.");
    }

    class Child : Parent
    {
        // 내가 새롭게 정의해서 사용
        public void Say() => Console.WriteLine("자식이 말하다.");

        // 새롭게 정의 : 오버라이드
        public new void Hi() => Console.WriteLine("자식이 인사하다.");

        // 새롭게 정의 : 오버라이드(override): 재정의
        public override void Walk() => Console.WriteLine("자식이 걷다.");
    }

    class MethodOverridePractice
    {
        static void Main()
        {
            ChildClass child = new ChildClass();
            child.Hi1();
            child.Hi2();
            child.Hi3();

            Child baby = new Child();
            baby.Say();
            baby.Hi();
            baby.Walk();
        }
    }
}
