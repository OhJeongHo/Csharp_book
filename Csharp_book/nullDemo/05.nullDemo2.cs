using System;
using System.Collections.Generic;


namespace nullDemo
{
    class Class1
    {
        static void Main()
        {
            // null 가능 형식에 null 병합 연산자 사용하기

            // value 값이 null이면 null 대신에 -1을 대입함 => null 때문에 발생하는 에러를 줄일 수 있다.
            int? value = null;
            int defaultValue = value ?? -1;
            Console.WriteLine(defaultValue);

            // null 병합 연산자와 default 키워드
            int? x = null;
            int y = x ?? 100;       // x가 null이면 100으로 초기화
            int z = x ?? default(int);  // 정수형의 기본값이 0으로 초기화
            //int z = x ?? default;       // 정수형의 기본값인 0 으로 초기화
            Console.WriteLine($"y : {y}, z : {z}");
            // default(int) 구문은 default로 줄여 표현해도 된다.

            // null 병합 연산자와 null 가능 형식을 함께 사용하기
            bool? unknown = null;
            if (unknown ?? true) // unknown이 null이면 true를 대입함
            {
                Console.WriteLine("출력됨");
            }
            unknown = false;
            if (!unknown ?? false)
            {
                Console.WriteLine("출력됨");
            }

            // null 조건부 연산자
            // ?. 연산자인 null 조건부 연산자는 null가능 형식 뒤에 붙어 해당 값이 null인지 테스트함.
            double? d = null;
            Console.WriteLine(d);
            Console.WriteLine(d?.ToString());   // d가 null이면 null을 반환
            d = 1.0;
            Console.WriteLine(d?.ToString());
            Console.WriteLine(d?.ToString("#.00"));


            // null 조건부 연산자 사용하기
            int? len;
            string message;

            message = null;
            len = message?.Length;
            Console.WriteLine(len);

            message = "안녕";
            len = message?.Length;
            Console.WriteLine(len);
            // ?. 연산자는 ?[] 형태로 배열 또는 인덱서에도 사용됨.


            // null 조건부 연산자와 컬렉션 클래스
            List<string> list = null;
            int? numberOfList;

            numberOfList = list?.Count; // 리스트가 null이면 null 반환
            Console.WriteLine(numberOfList);

            list = new List<string>();
            list.Add("안녕하세요."); list.Add("반갑습니다.");

            numberOfList = list?.Count; // 리스트가 null이 아니므로 Count 속성 값이 2 반환
            Console.WriteLine(numberOfList);


            // null 조건부 연산자와 null병합 연산자 함께 사용하기
            // ?.와 ?? 연산자를 함께 사용하는 예제.
            int num;
            List<string> list2;

            // 컬렉션 리스트가 null이면 count를 읽을 수 없기에 0으로 초기화
            list2 = null;
            num = list2?.Count ?? 0; // null이면 0반환, 오른쪽 값 사용
            Console.WriteLine(num);

            // 컬렉션 리스트가 null이 아니면 count 속성 값을 사용
            list2 = new List<string>();
            list2.Add("또 만나요.");
            num = list2?.Count ?? 0;    // null이 아니기에 왼쪽 값을 사용
            Console.WriteLine(num);
        }
    }
}
