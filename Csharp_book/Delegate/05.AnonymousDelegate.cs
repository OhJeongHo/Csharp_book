using System;

class AnonymousDelegate
{
    delegate void SayDelegate();

    static void Main()
    {
        // delegate 키워드로 함수를 바로 정의해서 사용
        SayDelegate say = delegate ()
        {
            Console.WriteLine("반갑습니다.");
        };
        say();
    }
}

// 이 코드는 익명 메소드 또는 무명 메소드라고 하는 메소드를 delegate 키워드로 만들고, 이를 SayDelegate 개체로 대신 호출
