using System;
using System.Collections.Generic;
using System.Linq;

// Cast<T>() 메소드로 List<자식>을 List<부모>로 변환
// List<T> 형태의 컬렉션 데이터를 부모 클래스 형태로 변경해야할 경우,
// LINQ에서 제공하는 ConvertAll()과 Cast<T>() 메소드를 사용하면 쉽게 변경 가능.

namespace ListOfChildToListOfParent
{
    interface A { }

    class B : A { }

    class ListOfChildToListOfParent
    {
        static void Main()
        {
            List<A> convertAll = (new List<B>()).ConvertAll(x => (A)x); // 1
            List<A> astoff = (new List<B>()).Cast<A>().ToList();    // 2

            Console.WriteLine(convertAll);
            Console.WriteLine(astoff);
        }
    }
}

// 1이나 2처럼 자식 클래스의 컬렉션 인스턴스를 부모 클래스의 컬렉션 인스턴스에 대입할 때는 ConvertAll() 또는 Cast<T>() 메소드를 사용할 수 있다.
// 현업에서 프로그램을 작성하다 보면 특정 인터페이스 또는 부모 클래스의 자식 클래스 값을 통합해서 사용할 때 이 두 메소드가 유용.
