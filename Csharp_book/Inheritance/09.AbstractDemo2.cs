using System;

public class Children : TableBase
{
    public string Name { get; set; }

    static void Main()
    {
        var child = new Children() { Id = 1, Active = true, Name = "아이" };
        if (child.Active)
        {
            Console.WriteLine($"{child.Id} - {child.Name}");
        }
    }
}