/*
 * 익명 형식
 * 익명 형식을 사용하면 특정 클래스로 형식을 만들 필요 없이 간단히 개체를 만들 수 있다.
 * 
 * 다음과 같은 간단한 코드로 Name과 Age 속성을 가지는 person 개체를 만들어 낼 수 있다.
 * new 키워드 뒤에 지정하는 속성들은 타입 추론을 이용하여 자동으로 string형과 int형으로 결정함.
 * 
 * var person = new { Name = "백승수", Age = 21 };
 * person.Name -> "백승수"
 * person.Age -> 21
 */
