using System;


namespace Csharp_book
{
    class EnumAnimal
    {
        enum Animal { Mouse, Cow, Tiger }

        static void Main()
        {
            Animal animal = Animal.Tiger;
            Console.WriteLine(animal);

            if (animal == Animal.Tiger)
            {
                Console.WriteLine("호랑이");
            }
        }
    }
}
