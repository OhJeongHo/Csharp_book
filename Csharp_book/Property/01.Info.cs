/*
 * 속성은 필드 값을 읽거나 쓰고 계산하는 방법을 제공하는 클래스 속성을 나타내는 맴버.
 * 간단하게 클래스 속성을 변경하거나 알아보는 기능들을 학습
 * 
 * 속성 : 클래스의 속성 - 특징,성격,색상,크기 등을 나타냄.
 * 속성은 괄호가 없는 메소드와 비슷하고 개체 필드 중에서 외부에 공개하고자 할 때 사용하는 방법
 * 
 * 클래스 안에 선언된 필드 내용을 설정(set)하거나 참고(get)할때 사용하는 코드 블록을 속성이라고 함.
 * 
 * Car 클래스에 Name 속성을 정의하는 구문은 다음과 같다.
 * class 클래스이름
 * {
 *      [반환형식] 속성이름 { get; set; }
 * }
 * 
 * class Car
 * {
 *      public string Name { get; set; }
 * }
 * 
 * 위와 같이 한줄로 속성을 정의하는 것을 자동 속성 또는 자동 구현 속성이라고 함.
 * Car 클래스의 인스턴스 생성 후 Name 속성에 값을 설정하거나 가져다 사용할 수 있다.
 * 
 * Car car = new Car();
 * car.Name = "My Car";
 * car.Name
 * 
 * 속성 정의 구문의 마지막에는 ;이 붙지 않는다.
 * 속성을 선언하는 구문도 클래스의 다른 맴버들과 마찬가지로 static을 붙여 정적인 속성을 만들 수 있다.
 * 
 * 속성에 값을 설정하는 것을 세터(setter)라고 하며, 값을 읽어 오는 것을 게터(getter)라고 함.
 * class Developer
 * {
 *      public string Name { get; set; }
 * }
 * Developer developer = new Developer();   1. 클래스의 인스턴스 생성
 * developer.Name = "박용준";                  2. 속성에 값 설정(set)
 * Console.WriteLine(developer.Name);       3. 속성 값 조회(get)
 */
