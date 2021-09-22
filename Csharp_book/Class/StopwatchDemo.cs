using System;
using System.Diagnostics;
using System.Threading;


namespace Class
{
    class StopwatchDemo
    {
        static void Main()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            LongTimeProcess();
            timer.Stop();

            // 밀리초 단위로 표시
            Console.WriteLine("경과 시간 : {0}밀리초", timer.Elapsed.TotalMilliseconds);
            // 초 단위로 표시
            Console.WriteLine("경과 시간 : {0}초", timer.Elapsed.Seconds);
        }

        static void LongTimeProcess()
        {
            // 3초간 대기 : Thread.Sleep() 메소드로 현재 프로그램 3초간 대기
            Thread.Sleep(3000);
        }
    }
}
