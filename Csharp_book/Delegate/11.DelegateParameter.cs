using System;

class DelegateParameter
{
    delegate void Runner();

    static void Main()
    {
        RunnerCall(new Runner(Go));
        RunnerCall(new Runner(Back));
    }

    // 특정 메소드의 매개변수에 대리자 형식을 지정하면, 해당 대리자를 받아 메소드 내에서 매개변수로 넘어오는 대신 호출해주는 메소드 실행
    static void RunnerCall(Runner runner) => runner();  // 넘어온 메소드(함수) 실행
    static void Go() => Console.WriteLine("직진");
    static void Back() => Console.WriteLine("후진");
}
