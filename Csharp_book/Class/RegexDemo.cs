using System;
using System.Text.RegularExpressions;

// 정규식은 만드려고하지말고 검색해서 찾을 것.

namespace Class
{
    class RegexDemo
    {
        static void Main()
        {
            string email = "abdc@aaa.com";
            Console.WriteLine(IsEmail(email));
        }

        static bool IsEmail(string email)
        {
            bool result = false;

            // 이메일을 검사하는 정규식은 인터넷에서 검색하여 사용 가능
            Regex regex = new Regex(
                @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)" +
            @"(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            result = regex.IsMatch(email);  // 패턴이 맞으면 true

            return result;
        }
    }
}
