using System;
using System.Collections;

// ArrayList 클래스는 컬렉션 형태의 데이터를 저장하고 관리하는 여러 편리한 API를 제공.
// 다만, 2.0버전부터 제공되는 제네릭관련 컬렉션을 사사용하기에 이후로는 ArrayList 클래스는 사용하지 않음.
namespace Collection
{
    class Class1
    {
        static void Main()
        {
            ArrayList list = new ArrayList();
            list.Add("C#");     // Add로 문자열 등을 저장. object 형식을 받기에 모든 데이터 형식을 저장하고 사용할 수 있음.
            list.Add("TypeScript"); // Remove() 메서드로 제거할 수 있다.

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());
            }
        }
    }
}
