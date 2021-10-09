// 속성에서 ?. 와 ?? 연산자를 함께 사요하기
// ?. 와 ?? 연산자를 사용하여 null 값을 편리하게 처리할 수 있다.

using System.Collections.Generic;
using static System.Console;


namespace NullWithObject
{
    class Person
    {
        public string Name { get; set; }
        public Address Address { get; set; }
    }

    class Address
    {
        public string Street { get; set; } = "알 수 없음";
    }

    class NullWithObject
    {
        static void Main()
        {
            var people = new Person[] { new Person { Name = "RedPlus" }, null };

            ProcessPeople(people);

            void ProcessPeople(IEnumerable<Person> peopleArray)
            {
                foreach (var person in peopleArray)
                {
                    // 1. ?.로 null을 확인하여 null 이면 ?? 이후의 문자열로 초기화
                    WriteLine($"{person?.Name ?? "아무개"}은(는) " + $"{person?.Address?.Street ?? "아무곳"}에 삽니다.");
                }
            }

            var otherPeople = null as Person[];

            // 2. ?[0] 형태로 인덱서에 대해 null 값 확인 가능
            WriteLine($"첫 번째 사람 : {otherPeople?[0]?.Name ?? "없음"}");
        }
    }
}


// 1 처럼 person?.Name 형태는 네임 속성이 null 이 아니면 해당 네임 속성을 사용하여 그렇지 않으면 null을 반환하여,
// ?? 연산자를 추가해서 null 대신 "아무개"를 반환하는 형태로 null을 처리.

// 2 처럼 otherPeople?[0]?.Name 형태로 [0]번쨰 인덱스의 배열 값이 null 인지 확인하는 조금 복잡하지만 null처리 효과적으로하는 연산자


// 속성은 클래스의 필드 값을 손쉽게 설정하고 읽기 편리하게 함.
// 이러한 속성은 개체 초기화와 익명 형식 등에서 자주 사용
// C#의 속성은 속성 개념이 없는 자바 같은 다른 언어에 비하여 코드의 간결함을 유지해주는 장점이 있다.
