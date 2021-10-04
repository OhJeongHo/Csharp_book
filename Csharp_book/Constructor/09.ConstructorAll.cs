using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 생성자도 정적 생성자와 인스턴스 생성자로 구분.
// 클래스의 정적 맴버를 호출할 때 맨 먼저 호출되는 정적 생성자는 static으로,
// 인스턴스 생성자는 public으로 만든다.
// static 생성자는 매개변수를 포함할 수 없다.

namespace ConstructorAll
{
    public class Person
    {
        private static readonly string _Name;
        private int _Age;

        static Person() // 1. 정적 생성자
        {
            _Name = "백승수";  
        }

        public Person() // 2. 인스턴스 생성자 : 매개변수가 없는 생성자
        {
            _Age = 21;
        }

        public Person(int _Age) // 3. 인스턴스 생성자 : 매개변수가 있는 생성자
        {
            this._Age = _Age;   // this.필드 = 매개변수;
        }

        public static void Show()   // 4. 정적 메소드
        {
            Console.WriteLine("이름 : {0}", _Name);
        }

        public void Print() // 5. 인스턴스 메소드
        {
            Console.WriteLine("나이 : {0}", _Age);
        }
    }

    class ConstructorAll
    {
        static void Main()
        {
            // a. 정적 생성자 실행
            Person.Show();  // 정적인 맴버 호출

            // b. 인스턴스 생성자 실행
            (new Person()).Print(); // 인스턴스 맴버 호출
            (new Person(22)).Print();
        }
    }
}
