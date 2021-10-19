using System;

namespace ConstructorBase
{
    class parent
    {
        // 매개변수로 넘어온 값 출력
        public parent(string message) => Console.WriteLine(message);
    }

    class Child : parent
    {
        // 1. base()를 사용하여 부모 클래스의 생성자 호출
        public Child(string message) : base(message) { }
    }

    class ConstructorBase
    {
        static void Main()
        {
            string message = "자식 클래스의 생성자를 호출할 때 부모 클래스의 생성자로 전달";
            var child = new Child(message);
        }
    }
}
