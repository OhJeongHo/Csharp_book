using System;
using System.Collections.Generic;

// 제네릭 개체를 초기화하는 세 가지 방법 정리
// 사용자 정의된 클래스를 List<T>제네릭 리스트 클래스의 T에 전달하여 구조화해서 사용할 수 있다.
// 특정 클래스 형태의 리스트 클래스로 12개월 일사량을 출력하는 방법 예제

public class Insolation
{
    public int Month { get; set; } // 월
    public float Value { get; set; }    // 일사량 값
}

class Test
{
    static void Main()
    {
        // 1. 개체 형식의 리스트 생성 : 컬렉션 이니셜라이저로 값 초기화
        List<Insolation> insolations = new List<Insolation>()
        {
            new Insolation { Month = 1, Value = 0.3f },
            new Insolation { Month = 2, Value = 0.6f },
            new Insolation { Month = 3, Value = 0.9f },
            new Insolation { Month = 4, Value = 1.2f },
        };

        // 2. Add() 메소드로 리스트에 값 추가 : 개체 이니셜라이저로 값 초기화
        insolations.Add(new Insolation() { Month = 5, Value = 1.5f });
        insolations.Add(new Insolation() { Month = 6, Value = 1.8f });
        insolations.Add(new Insolation() { Month = 7, Value = 1.6f });
        insolations.Add(new Insolation() { Month = 8, Value = 1.5f });

        // 3. AddRange() 메소드로 리스트에 값들 추가
        var tempInsolations = new List<Insolation>()
        {
            new Insolation { Month = 9, Value = 1.2f },
            new Insolation { Month = 10, Value = 0.9f },
            new Insolation { Month = 11, Value = 0.6f },
            new Insolation { Month = 12, Value = 0.1f },
        };

        insolations.AddRange(tempInsolations);

        Console.WriteLine("연간 일사량");    // 4. 리스트 출력

        foreach (var insolation in insolations)
        {
            Console.WriteLine($"{insolation.Month:00} - {insolation.Value}");
        }
    }
}
