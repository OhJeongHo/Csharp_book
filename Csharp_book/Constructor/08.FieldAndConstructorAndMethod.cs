using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 생성자 중 매개변수가 없는 생성자는 필드 값을 기본값으로 초기화하는 역할
// 매개변수가 있는 생성자는 개체를 생성할 때 넘겨준 문자열로 초기화
// 메소드는 필드 값을 외부에 공개하거나 직접 출력할 때 사용.

public class Person
{
    private string name;    // 1. 필드
    public Person()     // 2. 매개변수가 없는 생성자
    {
        name = "백승수";
    }

    public Person(string n) // 3. 매개변수가 있는 생성자
    {
        name = n;
    }

    public string GetName() // 4 메소드 : 이름 값을 외부에 공개
    {
        return name;
    }
}

class Test
{
    static void Main()
    {
        Person saram1 = new Person();   // 매개변수가 없는 기본 생성자 호출
        Console.WriteLine(saram1.GetName());

        var saram2 = new Person();
        Console.WriteLine(saram2.GetName());

        Person person1 = new Person("이세영"); // 매개변수가 있는 생성자 호출
        Console.WriteLine(person1.GetName());

        Person person2 = new Person("권경민");
        Console.WriteLine(person2.GetName());
    }
}
