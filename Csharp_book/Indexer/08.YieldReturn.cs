// 반복기와 yield 키워드
// 반복기(이터레이터iterator)는 배열과 컬렉션 형태의 데이터를 단계별로 실행하는 데 사용할 수 있다.
// 반복기를 구현할 때는 IEnumerable 인터페이스와 yield 키워드를 사용함.

// 디버거의 f11을 여러 번 눌러 디버깅 모드로 테스트할 것.

using System;
using System.Collections;

class YieldReturn
{
    // 1. 반복기(이터레이터) 구현 : MultiData() 메소드는 세 번 반복해서 문자열이 반환 됨.
    static IEnumerable MultiData()
    {
        yield return "Hello";
        yield return "World";
        yield return "C#";
    }

    static void Main()
    {
        // 2. 반복기를 foreach 문으로 호출해서 사용
        foreach (var item in MultiData())
        {
            Console.WriteLine(item);
        }
    }
}

// 1 의 MultiData() 메소드는 yield return 구문으로 세 번 문자열을 반환
// 이러한 yield return 구문은 IEnumberable 인터페이스 형식으로 반환됨
// 일반적으로 반복기를 만드는 공식과 코드 형태가 같다.
// 이 예제에서는 yield return 문을 3번 사용했으나, 반복문으로 감싸서 만드는 것이 일반적.