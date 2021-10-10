using System;

// 인덱서는 속성과 달리 이름을 따로 지정하지 않고 this 키워드를 사용하고 매개변수로 배열 형식을 받음.

class Catalog
{
    // 정수형 인덱서 : this[int index] 형태로 정의됨.
    public string this[int index]
    {
        get
        {
            return (index % 2 == 0) ? $"{index} : 짝수 반환" : $"{index} : 홀수 반환";
        }
    }
}

class IndexerNote
{
    static void Main()
    {
        Catalog catalog = new Catalog();
        Console.WriteLine(catalog[0]);  // 개체이름[인덱스] 형태로 호출 가능
        Console.WriteLine(catalog[1]);
        Console.WriteLine(catalog[2]);
    }
}
