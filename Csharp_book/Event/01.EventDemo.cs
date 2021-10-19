using System;

public class ButtonClass
{
    // 1. 이벤트 생성을 위한 대리자 하나 생성
    public delegate void EventHandler();    // 메소드를 여러 개 등록 후 호출 가능

    // 2. 이벤트 선언 : Click 이벤트
    public event EventHandler Click;

    // 3. 이벤트 발생 메소드 : OnClick 이벤트 처리기(핸들러) 생성
    public void OnClick()
    {
        if (Click != null)  // 이벤트에 등록된 값이 있는지 확인(생략 가능)
        {
            Click();    // 대리자 형식의 이벤트 수행
        }
    }
}

class EventDemo
{
    static void Main()
    {
        // a. Button 클래스의 인스턴스 생성
        ButtonClass btn = new ButtonClass();

        // b. btn 개체의 Click 이벤트에 실행할 메소드들 등록
        btn.Click += Hi1;
        btn.Click += Hi2;

        // c. 이벤트 처리기(발생 메소드)를 사용한 이벤트 발샐 : 다중 메소드 호출
        btn.OnClick();
    }

    static void Hi1() => Console.WriteLine("C#");
    static void Hi2() => Console.WriteLine(".NET");
}