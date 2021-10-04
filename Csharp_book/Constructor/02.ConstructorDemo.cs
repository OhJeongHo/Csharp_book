using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConstructorDemo   // 클래스
{
    public ConstructorDemo()    // 생성자
    {
        Console.WriteLine("생성자가 호출되었습니다.");
    }
    
    static void Main()
    {
        ConstructorDemo c = new ConstructorDemo();
    }
}
