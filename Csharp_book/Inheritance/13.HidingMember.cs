using System;

class Parent    // 1. 부모 클래스 생성
{
    public void Work() => Console.WriteLine("프로그래머");
}

// 부모에서 정의된 메소드를 new 키워드로 새롭게 정의해서 사용할 수 있다. => 오버라이드
class Child : Parent    // 2. 자식 클래스 생성
{
    // 기본 멤버 숨기기 : new -> 새롭게 정의, 다시 정의, 재정의
    public new void Work() => Console.WriteLine("프로게이머");
}

class Test
{
    static void Main()
    {
        var child = new Child();    // 자식 클래스의 인스턴스 생성
        child.Work();
    }
}
