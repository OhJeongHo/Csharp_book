using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public class MyMath
    {
        public void Sum(int x, int y)   // 1. 인스턴스 메소드 생성
        {
            int sum = x + y;
            Console.WriteLine($"합계 : {sum}");
        }

        // 1 처럼 static이 빠진 형태로 클래스 내에 메소드를 만들면 이 메소드는 인스턴스 메소드가 됨.
        // 인스턴스 메소드를 호출하려면 new 키워드를 사용해서 인스턴스를 생성해야 함.

        static void Main()
        {
            MyMath myMath = new MyMath();
            myMath.Sum(3, 5);
        }
    }
}
