/*
 * 자동으로 구현된 속성
 * 전체 속성을 쓰기 편하게 줄여 놓은 속성을 자동으로 구현된 속성이라고 함
 * 
 * public class Car
 * {
 *      // 필드와 속성을 함께 사용하는 전체 속성
 *      private string name;
 *      public string Name
 *      {
 *          get
 *          {
 *              return name; // 필드를 외부에 공개
 *          }
 *          set
 *          {
 *              name = value;   // 외부에서 전달된 값을 필드에 초기화
 *          }
 *      }
 *      
 *      // 자동으로 구현된 속성으로 간단하게 생성
 *      public string Color { get; set; }
 * }
 * 
 * Car c1 = new Car();
 * c1.Name = "람보르기니"
 * Console.WriteLine(c1.Name);
 * 
 * Car c2 = new Car();
 * c2.Name = "제네시스", c2.Color = "Red";
 * Console.WriteLine("{0}, {1}", c2.Name, c2.Color);
 * 
 * 
 * 자동 구현 속성 예제
 * class Exam
 * {
 *      public int Id { get; set; }
 *      public string Title { get; set; }
 * }
 * 
 * Exam exam = new Exam();
 * exam.Id = 1;
 * exam.Title = "중간고사";
 * Console.WriteLine($"{exam.Id} - {exam.Title}";
 */