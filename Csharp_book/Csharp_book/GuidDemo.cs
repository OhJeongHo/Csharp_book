using System;

namespace Csharp_book
{
    class GuidDemo
    {
        static void Main()
        {
            string unique = Guid.NewGuid().ToString();
            Console.WriteLine($"유일한 값 : {unique}");

            Console.WriteLine($"유일한 값 : {Guid.NewGuid().ToString()}");
        }
    }
}
