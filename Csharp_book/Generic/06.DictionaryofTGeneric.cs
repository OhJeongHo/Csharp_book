using System;
using System.Collections.Generic;

// 키와 값으로 데이터를 저장하고 사용할 수 있는 딕셔너리 제네릭 클래스.
namespace Generic
{
    class Class1
    {
        static void Main()
        {
            // 스트링키와 스크링값을 컬렉션으로 관리할 수 있는 데이터 개체
            // 딕셔너리 클래스의 인스턴스 생성 : IDictionary 인터페이스로 받기
            IDictionary<string, string> data = new Dictionary<string, string>();
            // 아래와 같이 써도 동일한 코드
            // var data = new Dictionary<string, string>();

            // 데이터 입력
            data.Add("cs", "C#");
            data.Add("aspx", "ASP.NET");

            // 데이터 삭제
            data.Remove("aspx");
            data["cshtml"] = "ASP.NET MVC"; // 인덱서를 사용해서 데이터 입력

            try
            {
                data.Add("cs", "C#");   // 키 값 중복 불가 : 에러 발생
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // 딕셔너리 개체값 출력
            // foreach(var item in data)로 줄임표현 가능
            foreach (KeyValuePair<string,string> item in data)
            {
                Console.WriteLine("{0}은(는) {1}의 확장자입니다.", item.Key, item.Value);
            }

            foreach (var item in data)
            {
                Console.WriteLine("{0}은(는) {1}의 확장자입니다.", item.Key, item.Value);
            }

            Console.WriteLine(data["cs"]);


            // 없는 키를 요청할 경우 에러 발생
            // 이때 TryGetValue() 또는 Containskey() 메소드를 사용해서 확인 또는 값을 추가할 수 있다.
            try
            {
                Console.WriteLine(data["vb"]);
            }
            catch (KeyNotFoundException knfe)
            {
                Console.WriteLine(knfe.Message);
            }

            // cs 키가 있으면 csharp 변수에 담아 출력
            if (data.TryGetValue("cs", out var csharp))
            {
                Console.WriteLine(csharp);
            }
            else
            {
                Console.WriteLine("cs 키가 없습니다.");
            }

            // 키 값이 없으면 입력하고 출력
            if (!data.ContainsKey("json"))
            {
                data.Add("json", "JSON");
                Console.WriteLine(data["json"]);
            }

            // 경우에 따라서 키와 값을 따로 컬렉션을 뽑아서 사용 가능

            // value 값을 따로 뽑아 출력
            var values = data.Values;
            Console.WriteLine(values);
            foreach (var item in values)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            // Key 값을 따로 뽑아서 출력
            var keys = data.Keys;
            Console.WriteLine(keys);
            foreach (var item in keys)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }
    }
}
