using System;

namespace NickNameDemo
{
    class NickNameDemo
    {
        static void Main()
        {
            // a. NickName 클래스의 인스턴스(개체) 생성
            var nick = new NickName();

            // b. 문자열 인덱서 사용
            nick["박용준"] = "RedPlus";    // Key와 Value 형태로 저장
            nick["김태영"] = "Teayo";

            // c. 문자열 인덱서 값 출력
            Console.WriteLine($"{nick["박용준"]}, {nick["김태영"]}");
        }
    }
}

// b 처럼 키와 값 쌍으로 데이터를 저장할 때는 Hashtable 또는 Dictionary 클래스를 사용하면 편함.