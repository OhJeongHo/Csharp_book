using System;

// 익명 형식은 무명 형식이라고도 함.
// 익명 형식은 프로그램 내에서 간단히 묶어 사용하는 개체에 대해 새로운 클래스를 만들지 않고 바로 개체로 만들때 유용

class AnonymousClass
{
    static void Main()
    {
        // 익명 형식으로 개체를 생성하고 속성 3개를 초기화
        var presenter = new { Name = "박용준", Age = 45, Topic = "C#" };

        Console.WriteLine($"{presenter.Name}, {presenter.Age}, {presenter.Topic}");
    }
}


// 익명 형식은 다음 코드 처럼 배열 형식으로도 사용 가능.
/*
 * var developers = new[] {
 *      new { Name = "RedPlus", Age = 45 },
 *      new { Name = "Taeyo", Age = 50 }
 *  };
 *  
 *  developers[0].Name      ->  "RedPlus"
 *  developers[1].Age       ->  50
 */
