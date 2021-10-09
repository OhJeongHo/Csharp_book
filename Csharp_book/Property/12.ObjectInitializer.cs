/*
 * 개체 이니셜라이저
 * 속성을 사용하여 개체 값을 설정하는 쉬운 방법을 제공
 * 다만, 생성자를 완전히 대체하지는 않는다.
 * 
 * class Course
 * {
 *      public int Id { get; set; }
 *      public string Title { get; set; }
 * }
 * 
 * 속성을 사용하여 개체 초기화
 * Course scharp = new Course();
 * csharp.Id = 1;
 * csharp.Title = "C#";
 * Console.WriteLine($"{csharp.Id} - {csharp.Title}");
 * 
 * 
 * 개체 이니셜라이저를 사용해서 개체 초기화
 * Course aspnet = new Course() { Id = 2, Title = "ASP.NET" };
 * Console.WriteLine($"{aspnet.Id} - {aspnet.Title}")
 * 
 * 
 * 개체 이니셜라이저를 사용하여 개체 속성 초기화하기
 * 1. Person 클래스 선언
 * class Person
 * {
 *      public string Name { get; set; }
 *      public string City { get; set; }
 * }
 * 
 * 2. 개체 이니셜라이저로 개체 속성 초기화하기
 * Person person = new Person { Name = "C#", City = "Seoul" }
 * Console.WriteLine($"{person.Name} : {person.City}");
 * 
 * Person 클래스의 인스턴스를 생성할 때 개체 이니셜라이저를 사용하여 속성을 초기화할 수 있다.
 * 선언과 동시에 초기화 가능
 */
