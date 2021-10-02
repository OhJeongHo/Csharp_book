using System;

    /*
    *  앞에서 닷넷에서 제공하는 수많은 클래스를 사용해 봤다.
    *  이번에는 이러한 클래스와 개체들을 직접 만들어본다.
    *  
    *  개체(오브젝트)는 설계도인 클래스에서 만든 인스턴스(실체, 구성요소) 하나를 의미함.
    *  
    *  class 키워드로 생성한 것을 클래스라고 하며,
    *  이러한 클래스를 new 키워드를 사용하여 새로운 이름으로 만든 것을 개체라고 함.
    */
namespace ClassAndObject
{
    class Program
    {
        // ClassCode 이름의 클래스 생성
        public class ClassCode
        {
            //Empty
        }

        // 특정 클래스에서 이름이 objectCode1, objectCode2인 개체 생성
        static void Main(string[] args)
        {
            ClassCode objectCode1 = new ClassCode();
            Console.WriteLine(objectCode1.GetHashCode());

            var objectCode2 = new ClassCode();
            Console.WriteLine(objectCode2.GetHashCode());
        }
        // 모든 개체는 GetHashCode() 메소드를 호출하여 고유의 키 값을 제공받을 수 있다.
        // 사용하는 클래스는 ClassCode로 동일하지만, 이 클래스로 만든 개체들은 서로 다른 인스턴스이다.
    }
}
