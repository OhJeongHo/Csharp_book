using System;

// 생성자로 속성에 대한 유효성 검사 구현하기
// 특정 속성은 반드시 특정 값으로 초기화해야 할 때가 있다.
// null 또는 빈 값이 들어오면 안 될 때가 있는데, 이떄는 생성자를 사용하여 반드시 특정 문자열을 넘겨주도록 강제.
// 넘어온 값이 null 또는 빈 값이면 에러를 강제로 발생시켜 좀 더 견고한 클래스를 만들 수 있다.

namespace PropertyValidation
{
    class Car
    {
        public string Name { get; private set; }
        public Car(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                // 빈 값이면 강제로 ArgumentException 예외 발생
                throw new ArgumentException();
            }

            this.Name = name;
        }
    }

    class PropertyValidation
    {
        static void Main()
        {
            // 정상 실행
            Car car = new Car("자동차");
            Console.WriteLine(car.Name);

            // 에외발생
            // Console.WriteLine((new Car("")).Name);
        }
    }
}
