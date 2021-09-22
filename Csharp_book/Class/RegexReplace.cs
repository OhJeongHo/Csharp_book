using System;
using System.Text.RegularExpressions;

// 정규식 = 문자열에서 특정 패턴을 찾아주는 기능
// 공백 여러 개를 하나로 치환하는 내용 => Regex 클래스를 통해서 가능
// Regex 클래스의 생성자에 전달된 \s 기호는 공백 문자를 의미.
namespace Class
{
    class RegexReplace
    {
        static void Main()
        {
            string s = "안녕하세요.  반갑습니다.  또 만나요.";
            var regex = new Regex("\\s+");  // 하나 이상의 공백 패턴 검사
            string r = regex.Replace(s, " ");   // 하나 이상의 공백을 고백 하나로 변환

            Console.WriteLine(s);
            Console.WriteLine(r);
        }
    }
}
