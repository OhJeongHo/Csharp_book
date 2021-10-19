using System;

public abstract class Shape // 1. 추상 클래스
{
    public abstract double GetArea();   // 2. 추상 멤버 : 추상 메소드
}

public class Square : Shape // 3. 추상 클래스를 상속하는 클래스
{
    private int _size;
    public Square(int size)
    {
        _size = size;
    }

    // 부모 클래스인 Shape 추상 클래스의 추상 멤버인 GetArea() 메소드를 구현
    public override double GetArea()
    {
        return _size * _size;
    }
}

class Test
{
    static void Main()
    {
        Square square = new Square(10);   // a. 자신의 이름으로 인스턴스 생성
        Console.WriteLine(square.GetArea());

        Shape shape = new Square(5);    // b. 부모의 이름으로 인스턴스 생성
        Console.WriteLine(shape.GetArea());

    }
}