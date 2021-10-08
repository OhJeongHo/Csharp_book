using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 가변 길이 매개변수
// 메소드의 매개변수를 받을 때 배열 형식의 매개변수를 하나 사용하여 가변적으로 하나 이상의 값을 받아 배열에 저장할 수 있는 가변형 매개변수.
// params 키워드를 사용하여 배열형 매개변수를 선언하면 됨.
// 메소드 오버로드와 달리 하나의 매개변수로 하나 이상의 값을 받을 수 있는 구조.

namespace Method
{
    class Class1
    {
        static void Main()
        {
            Console.WriteLine(SumAll(3, 5));
            Console.WriteLine(SumAll(3, 5, 7));
            Console.WriteLine(SumAll(3, 5, 7, 9));

        }

        static int SumAll(params int[] numbers) // 1. params로 매개변수를 여러 개 받기
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
    }
}

// SumAll() 메소드는 numbers라는 배열 형식의 매개변수를 하나 갖는다.
// 이때 params 키워드가 매개변수 앞에 붙어있어서 이 매개변수는 가변 길이 매개변수가 된다.
// 가변 길이 매개변수가 적용된 메소드는 하나 이상의 값을 가변적으로 호출할 수 있다.
