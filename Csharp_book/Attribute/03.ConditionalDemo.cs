// 특성의 매개변수를 전달할 수 있는데, 형태에 따라 위치 매개변수와 이름 매개변수로 구분.
// 위치 매개변수 : 특성에 전달되는 매개변수는 위치에 따라 구분됨
// 이름 매개변수 : 특성에 구현된 속성 또는 필드에 값을 전달할 때 사용. 다음 코드 처럼 WebServer 특성에 Namespace 속성 값을 전달
//[WebServer(Namespace="http://www.hawsaso.com/")]

// Conditional 특성을 사용하면 특정 기호에 따라 실행 여부를 결정할 수 있다.
// 프로젝트 탭 아래에 디버그/릴리즈 중 하나를 선택해서 실행여부 결정할 수 있다.

#define RELEASE  // 2-1. 전처리기 지시문으로 RELEASE 기호 정의
using System;
using System.Diagnostics;

public class ConditionalDemo
{
    static void Main()
    {
        DebugMethod();
        ReleaseMethod();
    }

    [Conditional("DEBUG")]  // 1. DEBUG 기호(심벌)를 가지는 경우 실행
    static void DebugMethod() => Console.WriteLine("디버그 환경에서만 표시");

    // 2-2. RELEASE 기호가 있는 경우 실행
    [Conditional("RELEASE")]
    static void ReleaseMethod() => Console.WriteLine("릴리스 환경에서만 표시");
}
