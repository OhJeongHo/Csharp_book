/*
 * Action, Func, Predicate 대리자
 * 
 * 닷넷 API에 내장된 유용한 제네릭 대리자에는 Action과 Func, Predicate가 있다.
 * 
 * Action 대리자 : 반환값이 없는 메소드를 대신 호출
 * Func 대리자 : 매개변수와 반환값이 있는 메소드를 대신 호출
 * Predicate 대리자 : T 매개변수에 대한 bool 값을 반환하는 메소드를 대신 호출
 */

using System;

class Test
{
    static void Main()
    {
        // Action<T> 대리자 사용하면 Console.WriteLine 같은 메소드를 대신 호출할 수 있다
        Action<string> printf = Console.WriteLine;  // Action 제네릭 대리자
        printf("메서드 대신 호출");

        // Func<T> 대리자 사용
        // Func<매개변수형식, 반환값형식>으로 특정 메소드 또는 익명 메소드를 대신 호출할 수 있는 대리자 개체를 만들 수 있다.
        Func<int, int> abs = Math.Abs;
        Console.WriteLine(abs(-10));

        Func<double, double, double> pow = Math.Pow;
        Console.WriteLine(pow(2, 20));

        Func<string, string> toLower = str => str.ToLower();
        Console.WriteLine(toLower("LambdaExpression"));

        Func<int, int> anonymous = delegate (int x) { return x * x; };  // 익명 메소드 담기
        Console.WriteLine(anonymous(2));

        Func<int, double> lambda = x => x / (double)2;
        Console.WriteLine(lambda(3));


        // Func 대리자 사용해서 람다식 만들기

        // 매개변수가 int고 반환값이 int인 람다 식
        Func<int, int> square = x => x * x;
        Console.WriteLine(square(3));

        // 무명 메소드와 람다 식 비교
        Func<int> getNumber1 = delegate () { return 1234; };
        Console.WriteLine(getNumber1());

        Func<int> getNumber2 = () => 1234;
        Console.WriteLine(getNumber2());

        Func<int, int> addOne1 = delegate (int x) { return x + 1; };
        Console.WriteLine(addOne1(10));

        Func<int, int> addOne2 = x => x + 1;
        Console.WriteLine(addOne2(10));

        Func<string, string, string> plus1 = delegate (string a, string b) { return $"{a} {b}"; };
        Console.WriteLine(plus1("Hello", "World"));

        Func<string, string, string> plus2 = (a, b) => $"{a} {b}";
        Console.WriteLine(plus2("Hello", "World"));
    }
}
