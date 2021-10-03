using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldNote
{
    class Person
    {
        private string name = "박용준";    // 1. 변수 형식의 필드
        private const int m_age = 21;   // 2. 상수 형식의 필드
        private readonly string _NickName = "RedPlus"; // 3. 읽기 전용 형식의 필드
        private string[] _websites = { "닷넷코리아", "비주얼아카데미" };    // 4. 배열 형식의 필드
        private object all = DateTime.Now.ToShortTimeString();  // 5. 모든 형식의 필드

        public void ShowProfile()
        {
            string r = $"{name}, {m_age}, {_NickName}, {String.Join(", ", _websites)}, " +
                $"{Convert.ToDateTime(all).ToShortTimeString()}";
            Console.WriteLine(r);
        }
    }

    class FieldNote
    {
        static void Main()
        {
            Person person = new Person();
            person.ShowProfile();
        }
    }
}
