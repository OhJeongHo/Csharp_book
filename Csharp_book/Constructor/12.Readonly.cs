using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 생성자를 사용하여 읽기 전용 필드 초기화
// 읽기 전용 필드는 클래스의 생성자로만 초기화가 가능함.
// 생성자로 초기화한 후에는 상수와 마찬가지로 값을 변경할 수 없다.

public class WhitchService
{
    private readonly string _serviceName;   // 읽기 전용 필드
    public WhitchService(string serviceName)
    {
        _serviceName = serviceName; // 생성자로 초기화해서 사용 가능
    }

    public void Run() => Console.WriteLine($"{_serviceName} 기능을 실행합니다.");
}

class Test
{
    static void Main()
    {
        var file = new WhitchService("[1] 파일 로그");
        file.Run();

        var db = new WhitchService("[2] DB 로그");
        db.Run();
    }
}

// 읽기 전용 필드는 클래스의 인스턴스를 생성할 대 넘어온 값에 따라
// 한번 선언한 후 변경되지 않고 사용할 수 있는 기능을 만든다.
// 상수는 선언과 동시에 반드시 초기화해야 에러가 발생하지 않지만,
// 읽기 전용 필드는 선언과 동이세 초기화도 가능하고,
// 선언한 후 생성자로 초기화 할 수도 있다.
