using System;

// 대리자 형식 변수에 메소드를 등록하는 코드
// 대리자 변수 = new 대리자(메소드이름);

// 대리자에는 += 연산자를 사용해서 대신할 메소드를 하나 이상 등록할 수 있다.
// 대리자 변수 += new 대리자(메소드이름);

// 대리자로 함수 대신 호출
// 델리게이트로 발음하는 대리자는 함수 포인터라고도 함. 다른 함수를 대신 호출하는 개념
// Hello() 이름으로 간단히 문자열만 출력하는 메소드를 대신 호출하는 SayPointer 대리자 사용하는 예제.

class DelegateNote
{
    // 1. 대리자 생성 : 매개변수도, 반환값도 없는 함수(메소드)를 담을 수 있는 포인터
    delegate void SayPointer();

    // 2. 샘플 함수 생성
    static void Hello() => Console.WriteLine("Hello Delegate");

    static void Main()
    {
        // a. 대리자의 인스턴스 생성 후 매개변수로 대신 실행할 함수 이름 전달
        SayPointer sayPointer = new SayPointer(Hello);

        // b. 대리자 인스턴스로 함수 대신 호출하는 두 가지 방법
        sayPointer();   // 대리자 변수에 괄호를 붙여 메소드 호출
        sayPointer.Invoke();    // 명시적으로 Invoke() 메소드 호출
    }
}
