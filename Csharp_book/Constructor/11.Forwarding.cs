using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// this() 생성자를 사용하면 생성자를 포워딩할 수 있으므로,
// 다른 생성자에 값을 전달하기 좋다.

class Money
{
    public Money() : this(1000) { } // 아래 생성자로 전송
    public Money(int money) => Console.WriteLine("Money : {0:#,###}", money);
}

class Test
{
    static void Main()
    {
        var basic = new Money();
        var bonus = new Money(2000);
    }
}

// 생성자 뒤에 오는 this()는 자신의 또 다른 생성자를 의미.
// 이러한 형태로 다른 생성자를 사용하여 값을 전달할 수 있다.
// 나중에 상속을 배우면 this()와 비슷하게 base()를 사용하여
// 부모 클래스의 생성자에게 값을 전달할 수도 있다.
