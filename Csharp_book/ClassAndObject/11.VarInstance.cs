using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 클래스의 인스턴스를 생성할 때 var 키워드를 사용하면 코드가 약간 짧아짐

public class ExamClass { }

class Var
{
    static void Main()
    {
        ExamClass exam1 = new ExamClass();
        Console.WriteLine($"{exam1}");

        // 클래스의 이름이 긴 경우 var로 줄여서 표현하는 것도 나쁘지 않다.
        var exam2 = new ExamClass();
        Console.WriteLine($"{exam2}");
    }
    // 정적 맴버 호출은 가내수공업으로 필요할 때 바로 호출해서 사용하는 개념
    // 인스턴스 맴버 호출은 대기업 기성품처럼 설계도를 바탕으로 개체를 대량으로 만들어 사용하는 형태
    // 프로그램 내에서 한두 번 호출하는 경우에는 정적 맴버를 사용하고,
    // 여러번 반복해서 사용하는 경우에는 인스턴스 맴버를 사용.
}
