using System;


namespace Class
{
    class EnvironmentExit
    {
        static void Main()
        {
            Console.WriteLine("출력됩니다");
            Environment.Exit(0);

            Console.WriteLine("출력될까요?");
        }
    }
}
/*
Environment.SystemDirectory     // 시스템 폴더
Environment.Version             // 닷넷 기준 버전
Environment.OSVersion           // 운영 체제 버전
Environment.MachineName         // 컴퓨터 이름
Environment.Username            // 사용자 이름
Environment.CurrentDirectory    // 현재 폴더
Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)    // 문서 폴더
 */
