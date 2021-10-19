using System;

// 닷넷에 내장된 IDisposable 인터페이스.
// 이를 상속하는 클래스는 Dispose() 메소드를 구현해야 함.
// 이 메소드는 해당 클래스의 개체를 다 사용한 후 마지막으로 호출해서 정리하는 역할.

class IDisposableDemo
{
    static void Main()
    {
        Console.WriteLine("[1] 열거");
        using (var t = new Toilet())
        {
            // 특정 프로세스를 종료하면 자동으로 닫기 수행
            Console.WriteLine("[2] 사용");
        }
    }
}

public class Toilet : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("[3] 닫기");
    }
}

/*
 * using 문은 IDisposable 인터페이스를 구현하는 개체를 올바르게 사용할 수 있도록 도와줌.
 * using 문으로 개체를 묶어 생성하면 해당 using문이 종료되면서 자동으로 Dispose() 메소드를 호출해서 정상 종료하도록 처리함.
 */
