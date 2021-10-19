using System;

// 인스턴스 형식 개체에 인스턴스 담기
// 인터페이스를 만들고 이를 특정 클래스에 상속하여 구현하여서 개체 생성하여 사용 가능.

// 1. 멤버 하나를 갖는 인터페이스 정의
public interface IRepository
{
    void Get();
}

// 2. 인터페이스를 상속하는 클래스 구현
public class Repository : IRepository
{
    public void Get()
    {
        Console.WriteLine("Get() 메소드를 구현해야 합니다.");
    }
}

class InterfacePractice
{
    static void Main()
    {
        // a. 인터페이스 형식 개체에 인스턴스 담기
        IRepository repository = new Repository();
        repository.Get();
    }
}

// 이러한 코드 모양은 리포지토리 패턴 이름으로 자주 사용됨.
