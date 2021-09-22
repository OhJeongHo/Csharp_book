using System;
using System.Diagnostics;


namespace Class
{
    class ProcessStartDemo
    {
        static void Main()
        {
            Process.Start("Notepad.exe"); // 메모장 실행

            // 웹 브라우저를 열고 매개변수로 URL을 전달함.
            Process.Start("Explorer.exe", "https://www.naver.com");
        }
    }
}
