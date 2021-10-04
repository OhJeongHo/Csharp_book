using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Circle
{
    private int _radius;

    public Circle(int radius)
    {
        _radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * _radius * _radius; // 원의 면적을 구하는 공식
    }
}

class Test
{
    static void Main()
    {
        var circle1 = new Circle(10);
        Console.WriteLine(circle1.GetArea());

        var circle2 = new Circle(5);
        Console.WriteLine(circle2.GetArea());
    }
}
