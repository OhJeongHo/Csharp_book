using System;

namespace PropertyNote
{
    class PropertyNote
    {
        static void Main(string[] args)
        {
            // 1. Car 클래스(정적) 사용
            Car.Color = "Black";    // 필드 사용
            Car.Type = "세단";    // 속성 사용
            Console.WriteLine($"차종 : {Car.Type}, 색상 : {Car.Color}");

            // 2. Person 클래스(인스턴스) 사용
            Person person = new Person("박용준");
            person.BirthYear = (DateTime.Now.Year - 21);    // 21살로 고정
            Console.WriteLine($"이름 : {person.Name}, 나이 : {person.Age}");
        }
    }
}


// 클래스 하나에 여러가지 필드값을 설정하거나 읽어올 때는 private 형식의 필드를 사용하고
// private 형식의 필드를 외부로 노출할 때는 public 형식의 속성을 사용해야 한다는 점을 기억.