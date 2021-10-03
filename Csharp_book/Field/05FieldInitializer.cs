using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Say
{
    // 필드를 선언과 동시에 초기화 = 필드 이니셜라이저
    private string message = "안녕하세요.";  // 1. 필드(멤버변수) - 필드 이니셜라이저

    public void Hi()    // 2. 메소드
    {
        this.message = "반갑습니다.";
        Console.WriteLine(this.message);
    }
}

class FiedlInitializer
{
    static void Main()
    {
        Say say = new Say();
        say.Hi();
    }
}
