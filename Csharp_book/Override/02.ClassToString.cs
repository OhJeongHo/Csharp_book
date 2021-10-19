using System;


namespace ClassToString
{
    class Person
    {
        private string name;
        public Person(string name)
        {
            this.name = name;
        }

        // ToString() 메소드 오버라이드(재정의)
        public override string ToString() => $"[Person 클래스 : {this.name}]";
    }

    class ClassToString
    {
        static void Main()
        {
            Person person = new Person("박용준");
            Console.WriteLine(person);  // 개체를 문자열로 출력하면 ToString()이 호출됨.

            // 기본적으로는 클래스 이름이 문자열로 반환되지만, 이를 재정의해서 원하는 문자열로 만들 수 있다.
        }
    }
}
