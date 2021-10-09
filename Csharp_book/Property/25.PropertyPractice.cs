using System;

class Fish
{
    public int Weight { get; set; } = 50;
    public void Feed(int weight) => Weight += weight;
}

class PropertyPractice
{
    static void Main()
    {
        var fish = new Fish();
        fish.Weight = 10;
        fish.Feed(15);
        Console.WriteLine(fish.Weight);

        (new Point()).Draw();
    }
}

class Point
{
    public int X { get; set; } = 100;
    public int Y { get; set; } = 200;

    public void Draw() => Console.WriteLine($"X : {this.X}, Y : {this.Y}");
}

