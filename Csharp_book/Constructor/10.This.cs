using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 생성자에서 this()는 자신의 또 다른 생성자를 의미.
// this() 생성자로 매개변수가 있는 생성자에서 매개변수가 없는 생성자를 호출하거나
// 또 다른 생성자들을 호출할 수 있다.

// 1 에서 매개변수가 있는 생성자 뒤에 콜론 기호와 this()를 사용하여,
// 자신의 매개변수가 없는 생성자를 먼저 호출하는 코드 형태를 볼 수 있다.
// 그런 다음 다시 매개변수가 있는 생성자를 호출할 수 있다.

class Say
{
    private string message = "[1] 안녕하세요.";
    public Say() => Console.WriteLine(this.message);

    // 1. this() 생성자로 자신의 매개변수가 없는 생성자를 먼저 호출
    public Say(string message) : this()
    {
        this.message = message; // 2. 매개변수가 있는 생성자 자체도 호출
        Console.WriteLine(this.message);
    }
}

class Test
{
    static void Main()
    {
        // 매개변수가 있는 생성자를 호출할 때 매개변수가 없는 생성자도 함께 호출
        new Say("[2] 잘가요.");
    }
}
