using System;

class AnonymousType
{
    static void Main()
    {
        var data = new { Id = 1, Name = "익명 형식" };
        Console.WriteLine($"{data.Id} - {data.Name}");
    }
}

// 개체를 만들 떄는 new 키워드 뒤에 특정 데이터 형식을 지정하는데,
// 이것 대신에 중괄호 안에 직접 원하는 속성 이름과 속성 값을 바로 지정하여 이름이 없는 익명 형식을 만들 수 있다.