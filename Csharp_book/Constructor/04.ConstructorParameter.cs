using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 매개변수가 있는 생성자는 클래스 내에 선언된 특정 필드값을 초기화하는 목적으로 많이 사용.

public class Dog    // 1. 클래스
{
    private string name;    // 2. name 필드
    public Dog(string name) // 3. name 매개변수를 받아 name 필드에 저장하는 생성자
    {
        this.name = name;   // 넘어온 name을 name 필드에 임시 저장
    }
    public string Cry() // 4. name 필드 값을 출력하는 반환 값이 있는 메소드
    {
        return name + "이(가) 멍멍멍";
    }
}
class Test
{
    static void Main()
    {
        // Dong 클래스 사용 : happy, worry => 인스턴스, 개체, ...
        Dog happy = new Dog("해피");
        Console.WriteLine(happy.Cry());

        Dog worry = new Dog("워리");
        Console.WriteLine(worry.Cry());
    }
}
