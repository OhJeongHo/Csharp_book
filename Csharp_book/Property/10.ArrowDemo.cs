using System;


// 화살표 연산자로 속성과 메소드를 줄여서 표현할 수 있다.
// 속성을 줄여 표현하는 방법을 식 본문 속성이라고 함

class Counter
{
    private int count;

    public int Count
    {
        get => count;
        set => count = value;
    }

    public void IncreaseCount() => Count++;
}

class ArrowDemo
{
    static Counter counter;
    static void Main()
    {
        counter = new Counter();
        counter.IncreaseCount();
        Console.WriteLine($"카운트 : {counter.Count}");
    }
}
