using System;

// 명시적인 인터페이스 구현하기
// 인터페이스를 사용한 다중 상속이 가능하기에 각 인터페이스에 동일한 멤버가 구현되어 있을 때가 있다.
// 이때는 명시적으로 어떤 인터페이스의 멤버를 실행할지 지정해야한다.

interface IDog
{
    void Eat();
}

interface ICat
{
    void Eat();
}

class Pet : IDog, ICat
{
    void IDog.Eat() => Console.WriteLine("Dog Eat");    // 1. 명시적으로 IDog 지정
    void ICat.Eat() => Console.WriteLine("Cat Eat");    // 2. 명시적으로 ICat 지정
}

class InterfaceExplicit
{
    static void Main()
    {
        Pet pet = new Pet();
        ((IDog)pet).Eat();  // a. pet 개체를 IDog 형식으로 변환
        ((ICat)pet).Eat();  // b. pet 개체를 ICat 형식으로 변환

        IDog dog = new Pet();
        dog.Eat();
        ICat cat = new Pet();
        cat.Eat();
    }
}