/*
 * nameof 연산자를 사용하면 속성 이름 자체를 문자열로 가져올 수 있다.
 * nameof 연산자는 식별자 또는 변수 이름에 대한 리팩터링 및 이름을 변경할 때 유용.
 * 이것으로 이름 바꾸기 등 IDE 기능을 사용할 수 있음.
 * 
 * throw new ArgumentNullException("Product");
 * =
 * throw new ArgumentNullException(nameof(product));
 * 
 * 
 * 속성 이름을 nameof 연산자로 가져오기
 * class Car
 * {
 *      public string Maker { get; set; }
 * }
 * Car car = new Car();
 * Console.WriteLine(nameof(car.Maker)); -> Maker
 */
