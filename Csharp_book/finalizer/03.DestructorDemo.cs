using System;

namespace DestructorDemo
{
    public class Car
    {
        private string _name;   // 필드
        public string GetName() // 메소드
        {
            return _name;
        }

        public Car()    // 생성자 - 매개변수가 없는
        {
            _name = "승용차";
        }
        public Car(string name) // 생성자 - 매개변수가 있는
        {
            this._name = name;
        }
        ~Car()
        {
            Console.WriteLine("{0} 폐차...", _name);
        }
    }

    class DestructorDemo
    {
        static void Main(string[] arg)
        {
            Car car1 = new Car();
            Console.WriteLine(car1.GetName());
            Car car2 = new Car("캠핑카");
            Console.WriteLine(car2.GetName());
        }
    }
}