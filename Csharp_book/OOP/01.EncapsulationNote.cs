using System;

// 캡슐화 사용
// private를 사용하여 속성을 감추는 것.

namespace EncapsulationNote
{
    public class Person
    {
        // 1. 필드
        private string name;

        // 2. 메소드 : public 메소드 또는 속성으로 외부에 공개
        public void setName(string n) => name = n;
        public string GetName() => this.name;
    }

    class EncapsulationNote
    {
        static void Main()
        {
            // a. person 개체 생성
            Person person = new Person();
            // b. Set 메소드로 필드 설정
            person.setName("C#");
            // c. Get 메소드로 필드 공개
            Console.WriteLine(person.GetName());
        }
    }
}
