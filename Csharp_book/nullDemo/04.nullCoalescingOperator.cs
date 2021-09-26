using System;

// ?? 연산자인 null 병합 연산자는 왼쪽 항이 null이 아니면 해당 값을 반환하고, 그렇지 않으면 오른쪽 값을 반환.
namespace nullDemo
{
    class Class1
    {
        static void Main()
        {
            string nullValue = null;
            string message = "";

            // if 구문으로 null 값 비교
            nullValue = null;
            if (nullValue == null)
            {
                message = "[1] null이면 새로운 값으로 초기화합니다.";
            }
            Console.WriteLine(message);

            // ?? 연산자로 null값 비교
            nullValue = null;
            message = nullValue ?? "[2] null이면 새로운 값으로 초기화합니다.";
            Console.WriteLine(message);

            nullValue = "Hello";
            message = nullValue ?? "[3] Nothing";
            Console.WriteLine(message);


            var result = "";
            message = "";

            message = null;
            result = message ?? "기본값";
            Console.WriteLine(result);

            message = "있는 값";
            result = message ?? "기본값";
            Console.WriteLine(result);
        }
    }
}
