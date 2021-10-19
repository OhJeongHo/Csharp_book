using System;

abstract class GeneralManager   // 부장님 클래스 생성
{
    public abstract void SayHumor();    // 메소드 본문 생략
}

class Person : GeneralManager   // 부장님 클래스를 상속하는 사람 클래스 생성
{
    public override void SayHumor()
    {
        Console.WriteLine("1+1은? 노가다!");
    }
}

class Test
{
    static void Main()
    {
        var person = new Person();
        person.SayHumor();
    }
}