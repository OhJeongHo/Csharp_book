using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ToString() 메소드 오버라이드
// 클래스에는 ToString() 메소드로 특별한 메소드를 생성할 수 있는데, 개체에 대한 문자열을 재정의.
// 이러한 기능을 ToString 메소드 오버라이드라고 함.

class My { }

class Your
{
    public override string ToString()
    {
        return "새로운 반환 문자열 지정";
    }
}

class ToStringMethod
{
    static void Main()
    {
        My my = new My();
        Console.WriteLine(my); // "My": 개체를 출력하면 기본은 클래스 이름이 출력

        Your your = new Your();
        Console.WriteLine(your);    // 새로운 반환 문자열 지정
    }
}

// 클래스를 만들 때 public override strting ToString() {} 메소드를 구현하고 문자열을 반환하면
// 그에 해당하는 문자열을 재정의하여 기본 개체를 출력할 수 있다.
