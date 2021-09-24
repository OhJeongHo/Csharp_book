using System;
using System.Collections;

// Hashtable은 배열처럼 [0], [1] 형태로 데이터를 저장할 수 있고 문자열 형태의 인덱스도 사용할 수 있다.
// 닷넷에서는 컬렉션 관련 클래스를 굉장히 많이 제공.
// Stack, Queue, ArrayList 등은 전통적으로 많이 사용하는 클래스이므로 반드시 기억하고 넘어가되,
// 제네릭 버전의 클래스로 대체해서 사용해야함.
namespace Collection
{
    class Class1
    {
        static void Main()
        {
            Hashtable hash = new Hashtable();

            // 배열형 인덱서를 사용 가능한 구조 및 문자열 인덱스 사용 가능
            hash[0] = "닷넷코리아";      // 배열과 같은 n번째 형태 사용 가능
            hash["닉네임"] = "레드플러스";  // 문자열 인덱스 사용 가능
            hash["사이트"] = "비주얼아카데미";

            // 직접 출력
            Console.WriteLine(hash[0]);
            Console.WriteLine(hash["닉네임"]);
            Console.WriteLine(hash["사이트"]);

            // key와 value 쌍으로 출력 가능
            foreach (object o in hash.Keys)
            {
                Console.WriteLine(hash[o]);
            }
        }
    }
}
