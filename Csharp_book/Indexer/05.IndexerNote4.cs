using System;

// 배열 형식의 필드를 사용하는 인덱서
// 요일 정보를 담아 놓을 수 있는 형태의 개체

public class Week   // 요일 이름을 저장해 놓는 클래스
{
    // 1. 필드 : 요일 문자열을 담아 놓을 수 있는 문자열 배열
    private string[] _week;
    public int Length { get; }  // 3. 속성

    public Week()   // 2-1. 생성자 : 매개변수가 없는 생성자
    {
        Length = 7; // 기본값 초기화
        _week = new string[Length]; // 요소 7개를 갖는 배열 생성
    }

    public Week(int length) // 2-2. 생성자 : 매개변수가 있는 생성자
    {
        Length = length;
        _week = new string[Length];
    }

    // 4. 인덱서 : 개체를 배열 형태로 사용하도록 this[] 형태의 인덱서 생성
    public string this[int index]
    {
        get { return _week[index]; }
        set { _week[index] = value; }
    }
}

class Test
{
    static void Main()
    {
        Week week = new Week(3);    // a 배열 형식 생성
        week[0] = "일요일";    // b 인덱서로 문자열 값을 초기화
        week[1] = "월요일";
        week[2] = "화요일";

        for (int i = 0; i < week.Length; i++)   // c 출력 : 인덱서로 배열 형식의 필드값 출력
        {
            Console.WriteLine($"{week[i]}");
        }
    }
}