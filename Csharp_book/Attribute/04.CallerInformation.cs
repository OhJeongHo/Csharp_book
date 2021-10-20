// 특성을 사용하여 메소드 호출 정보 얻기

using System.Runtime.CompilerServices;
using static System.Console;

class CallerInformation
{
    static void Main()
    {
        TraceMessage("여기서 무엇인가 실행...");
    }

    // 메소드의 매개변수 앞에 CallerMemberName/FilePath/LineNumber 등 특성을 사용하여 메소드를 호출한 호출자 정보를 얻을 수 있다.
    public static void TraceMessage(string message,
        [CallerMemberName] string memberName = "",
        [CallerFilePath] string sourceFilePath = "",
        [CallerLineNumber] int sourceLineNumber = 0)
    {
        WriteLine("실행 내용 : " + message);
        WriteLine("멤버 이름 : " + memberName);
        WriteLine("소스 경로 : " + sourceFilePath);
        WriteLine("실행 라인 : " + sourceLineNumber);
    }
}
