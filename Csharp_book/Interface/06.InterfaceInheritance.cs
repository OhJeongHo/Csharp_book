using System;

// 인터페이스를 사용한 다중 상속 구현

namespace InterfaceInheritance
{
    interface IAnimal
    {
        void Eat();
    }

    interface IDog
    {
        void Yelp();
    }

    class Dog : IAnimal, IDog   // 인터페이스를 사용한 다중 상속
    {
        public void Eat() => Console.WriteLine("먹다.");
        public void Yelp() => Console.WriteLine("짖다.");
    }

    class InterfaceInheritance
    {
        static void Main()
        {
            Dog dog = new Dog();
            dog.Eat();  // a. IAnimal 인터페이스 상속
            dog.Yelp(); // b. IDog 인터페이스 상속
        }
    }
}
