using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Class1
    {
        /*
         * 링큐에서 제공하는 확장 메소드들은 매개변수로 람다식을 받는다.
         * 람다 식은 화살표 연산자 또는 람다 연산자라고 하는 화살표 모양의 => 기호를 사용
         * => 연산자는 일반적으로 영어로는 goes to 또는 arrow로 발음함.
         * 람다식은 두가지 형태로 표현함. -> 식 람다, 문 람다
         * 
         * 식 람다 : (입력 매개변수) => 식    / 예 :   x => x + 1
         * 문 람다 : (입력 매개변수) => { 문; }   / 예 :   x => { return x + 1; }
         */

        static void Main()
        {
            Func<int, bool> isEven = x => x % 2 == 0;
            Console.WriteLine(isEven(2));
            Console.WriteLine(isEven(3));

            Action<string> greet = name => { var message = $"Hello {name}"; Console.WriteLine(message); };
            greet("You");

            // Where() 메소드를 사용하여 조건을 처리할 수 있다.
            // Where() 메소드의 결과값은 IEnumberable<T>이다. => List<T>와 비슷하지만 읽기전용 컬렉션
            // Where() 메소드로 IEnumerable<T> 형태의 데이터 가져오기
            int[] numbers = { 1, 2, 3, 4, 5 };
            IEnumerable<int> newNumbers = numbers.Where(number => number > 3);
            foreach (var n in newNumbers)
            {
                Console.WriteLine(n);
            }
            // number = > number > 3은 매개변수가 들어오면 3 보다 큰 데이터만 가져온다.

            // ToList() 메소드로 IEnumerable<T>를 List<T>로 변환하기
            // 람다식을 사용하는 Where() 같은 확장 메소드를 호출할 때 List<T>로 받으려면 ToList()메소드를 한번 더 호출해야함.
            int[] nums = { 1, 2, 3, 4, 5 };
            List<int> newNums = nums.Where(number => number > 3).ToList();
            foreach (var number in newNums)
            {
                Console.WriteLine(number);
            }


            // Where() 메소드로 조건 처리하기
            // Where() 확장 메소드는 람다식을 사용하여 조건을 처리할 수 있다.
            var n = new List<int> { 1, 2, 3 };
            Console.WriteLine(n.Where(number => number % 2 == 0).Sum());
            // 컬렉션에서 짝수만 가져온 후 그 짝수들의 합만 구하는 코드.
            var nn = new List<int> { 1, 2, 3 };
            Console.WriteLine(nn.Where(n => n % 2 ==1).Sum());
            // Where() 메소드에 매개변수로 전달되는 람다식의 매개변수 이름은 일반적으로 컬렉션의 첫글자를 따서 만드는 것이 관례.
        }
    }
}
