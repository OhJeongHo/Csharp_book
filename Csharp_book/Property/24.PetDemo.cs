using System;

// 메소드로 속성 값 초기화하기
// 속성과 메소드를 함께 사용하는 예제
// 클래스와 속성을 만들고 /// 를 입력하면 자동으로 XML 주석인 서머리 코드 주석이 만들어짐.

/// <summary>
/// 애완동물
/// </summary>
class Pet
{
    /// <summary>
    /// 몸무게
    /// </summary>
    public int Weight { get; set; }

    /// <summary>
    /// 먹이를 주면 몸무게 증가
    /// </summary>
    /// <param name="weight">몸무게</param>
    public void Feed(int weight)
    {
        Weight += weight;
    }
}

class PetDemo
{
    static void Main()
    {
        Pet pet = new Pet();
        pet.Weight = 50;    // 속성으로 값 초기화
        pet.Feed(10);   // 메소드로 값 증가
        Console.WriteLine(pet.Weight);
    }
}
