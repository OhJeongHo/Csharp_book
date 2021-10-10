using System;

// 인덱서를 사용하여 여러 값 주고받기

class Developer
{
    private string name;
    public string this[int index]   // 인덱서
    {
        get { return name; }    // [index]로 요청하면 특정 필드 값을 반환
        set { name = value; }   // 넘어온 값은 value 키워드로 읽어 올 수 있음.
    }
}

class Test
{
    static void Main()
    {
        var developers = new Developer();
        developers[0] = "백승수";  // 인덱스와 상관없이 name 필드에 문자열이 저장됨.
        Console.WriteLine(developers[0]);
        developers[1] = "이세영";
        Console.WriteLine(developers[1]);
    }
}