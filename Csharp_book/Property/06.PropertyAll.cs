using System;

namespace PropertyAll
{
    public class Car
    {
        private string color; // 필드

        public Car()    // 생성자
        {
            this.color = "Black";
        }

        // 메소드로 외부에 공개
        public void SetColor(string color)
        {
            this.color = color; // this.필드 = 매개변수;
        }

        public string GetColor()
        {
            return color;
        }

        // 속성
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        // 읽기 전용 속성
        public string Make
        {
            get
            {
                return "한국자동차";
            }
        }

        // 쓰기 전용 속성
        private string _Type;
        public string Type
        {
            set
            {
                _Type = value;
            }
        }

        // 축약형 속성
        public string Name { get; set; }
    }

    class PropertyAll
    {
        static void Main()
        {
            // 1. Set과 Get 메소드 사용
            Car car1 = new Car();
            car1.SetColor("Red");
            Console.WriteLine(car1.GetColor()); // red

            // 2. 속성을 이용
            Car whiteCar = new Car();
            whiteCar.Color = "White";   // set
            Console.WriteLine(whiteCar.Color);  // get

            // 3. 읽기 전용 속성
            Car k = new Car();
            // k.Make = ""; 이 코드는 에러 발생
            Console.WriteLine(k.Make);  // 읽기만 가능

            // 4. 쓰기 전용 속성
            Car car = new Car();
            car.Type = "중형";    // 쓰기만 가능
            // Console.WriteLine(car.Type); 이 코드는 에러 : 읽기는 불가

            // 5. 축약형 속성
            Car myCar = new Car();
            myCar.Name = "좋은차";
            Console.WriteLine(myCar.Name);
        }
    }
}