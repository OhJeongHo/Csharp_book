/*
 * 속성의 get 과 set 구문을 하나만 사용하여 읽기 전용 속성과 쓰기 전용 속성을 구현할 수 있다.
 * 속성을 선언과 동시에 값을 초기화하고 private set 절을 사용하면,
 * 설정(set)이 불가능한 읽기 전용 속성을 만들 수 있다.
 * 
 * 
 * public class Page
 * {
 *      public string Message { get; private set; } = "읽기 전용 속성";
 * }
 * Page page = new Page();
 * page.Message = "외부에서 쓰기 불가능"; -> 이 부분에서 오류 발생 / 읽기 전용 속성이라서 읽기만 가능.
 */
