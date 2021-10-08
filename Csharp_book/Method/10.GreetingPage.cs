using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 특정 클래스의 메소드와 Main() 메소드를 줄여서 표현

namespace Method
{
    class Greeting
    {
        private string message = "사이트에 오신 것을 환영합니다.";
        public void Say() => Console.WriteLine(this.message);
    }

    class GreetingPage
    {
        static void Main() => (new Greeting()).Say();
    }
}
