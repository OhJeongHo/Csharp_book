/*
 * 자동 속성을 사용하면 표 형태의 데이터, 즉 레코드 단위로 데이터를 저장할 때 유용.
 * 배열을 사용하던 전통적인 프로그래밍 방식에서 속성을 사용하여 레코드 형태로 데이터를 관리하는 클래스를 모델 클래스라고 함.
 * 
 * public class Customer
 * {
 *      public int Id { get; set; }
 *      public string Name { get; set; }
 *      public string City { get; set; }
 * }
 * 
 * 개체 리터럴을 사용하여 개체 초기화
 * var customer = new Customer { Id = 1, Name = "박용준", City = "인천" };
 * 
 * 속성으로만 된 데이터 클래스인 Customer 클래스를 만들고 사용.
 */
