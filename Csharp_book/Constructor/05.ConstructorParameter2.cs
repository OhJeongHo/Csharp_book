using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ctor 입력 후 탭 2번 치면 생성자 자동으로 완성됨.

namespace Constructor
{
    class My
    {
        private string _name;
        private int _age;

        public My(string name, int age)
        {
            this._name = name;  // this.필드 = 매개변수
            this._age = age;
        }
        public void PrintMy()
        {
            Console.WriteLine($"이름 : {this._name}, 나이 : {this._age}");
        }
    }

    class ConstructorParameter
    {
        static void Main()
        {
            My my = new My("백승수", 21);
            my.PrintMy();
        }
    }
}
