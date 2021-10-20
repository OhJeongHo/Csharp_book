using System;
using System.Collections.Generic;

// 컬렉션 이니셜라이저로 제네릭 리스트 초기화하기
// 컬렉션 이니셜라이저는 컬렉션 값을 초기화하는 쉬운 방법을 제공
// 특정 클래스 형식의 리스트를 한 번에 초기화하는 컬렉션 이니셜라이저를 사용.

class Person
{
    public string Name { get; set; }
}

class Test
{
    static void Main()
    {
        List<Person> people = new List<Person>
        {
            new Person { Name = "백승수" },
            new Person { Name = "이세영" },
            new Person {Name = "권경민"}
        };

        foreach (var person in people)
        {
            Console.WriteLine(person.Name);
        }
    }
}

// List<T> 형태의 컬렉션 개체를 선언과 동시에 특정 개체 값으로 초기화할 수 있다. 이것을 컬렉션 이니셜라이저라고 함.
