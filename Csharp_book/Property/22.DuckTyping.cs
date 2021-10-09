/*
 * 익명 형식과 덕 타이핑
 * 
 * 덕 타이핑 : 새인데 오리처럼 생겼고, 오리처럼 수영하며, 오리처럼 꽥꽥 되면 나는 그 새를 오리라고 하겠다.
 * 
 * 익명 형식 개체 생성
 * var duck = new { Id = 1, Name = "Duck 1" };
 * 값 출력
 * Console.WriteLine($"{duck.Id} - {duck.Name}")    ->  "1 - Duck 1"
 * 
 * duck 개체에 또다른 익명 형식을 대입 / 앞에서 선언한 형태와 속성과 형식이 동일한 개체를 대입해야 함.
 * duck = new { Id = 2, Name = "DUck 2" }
 * 값 출력
 * Console.WriteLine($"{duck.Id} - {duck.Name}")    ->  "2 - Duck 2"
 * 
 * 이번에는 처음에 선언한 형태가 아닌 Id에 실수 데이터를 입력 시
 * 처음 선언된 duck 개체와 다른 개체가 대입되기에 예외가 발생
 * duck = new { Id = 3.14, Name = "Duck 3" };   ->  예외 발생
 * 
 * Name 속성을 제외한 채 개체 할당할 경우, 이 떄도 예외가 발생
 * duck = new { Id = 3 };   ->  예외 발생
 * 
 * 처음에 없던 Email 속성을 추가해서 할당해도 예외 발생
 * duck = new { Id = 3, Name = "Duck 3", Email = "Email 3" };
 * 
 * 처음 개체가 만들어지면 그 형식과 동일한 형태로만 다시 할당된다.
 * 이를 덕 타이핑이라고 한다.
 */
