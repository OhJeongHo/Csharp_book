using System;

public class Circle
{
    public int Radius { get; private set; } = 0;
    public Circle(int radius) => Radius = radius;
    public Circle MakeNew(int radius) => new Circle(radius);
}

class Test
{
    static void Main()
    {
        // 1. 생성자로 반지름이 10인 Circle 개체 생성
        Circle circle = new Circle(10);
        Console.WriteLine($"Radius : {circle.Radius} - {circle.GetHashCode()}");

        // 2. 메소드로 반지름이 20인 circle 개체 생성
        circle = circle.MakeNew(20);
        Console.WriteLine($"Radius : {circle.Radius} - {circle.GetHashCode()}");
    }
}