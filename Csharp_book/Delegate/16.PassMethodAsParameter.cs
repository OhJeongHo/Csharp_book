using System;

class PassMethodAsParameter
{
    // 1. 입력한 문자열 길이를 반환하는 메소드
    static int StringLength(string data) => data.Length;

    // 2. 매개변수가 string이고 반환값이 int인 메소드를 매개변수로 받아 사용
    static void StringLengthPrint(Func<string, int> stringLength, string message)
        => Console.WriteLine($"메시지의 크기는 {stringLength(message)}입니다.");

    // 3. 메소드의 매개변수로 특정 메소드 전달
    static void Main() => StringLengthPrint(stringLength, "안녕하세요.");
}

