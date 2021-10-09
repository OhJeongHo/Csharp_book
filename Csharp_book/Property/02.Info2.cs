/*
 * 속성에 접근자를 사용하여 값을 설정하거나 가져오는 기능을 수행할 수 있다.
 * 접근자로 값을 가져오는 get 접근자와 값을 설정하는 set 접근자를 제공.
 * 하나만 사용하거나 모두 사용할 수 있고, 게터와 세터로 읽는다.
 * 
 * 전체속성 형태
 * class Car
 * {
 *      private string name;
 *      public string Name
 *      {
 *          get
 *          {
 *              return name;
 *          }
 *          set
 *          {
 *              name = value;
 *          }
 *      }
 * }
 * 
 * class Person
 * {
 *      private string name;    // 필드
 *      public string Name
 *      {
 *          get { retturn name; }
 *          set { name = value }
 *      }
 * }
 * var person = new Person();
 * person.Name = "Gilbut";          // set
 * Console.WriteLine(person.Name);  // get
 * 
 * 
 * 자동 속성이 나오기 전까지는 전체 속성을 사용했었다.
 * 최근에는 특별한 경우가 아니면 자동속성을 사용함.
 * 
 * prop를 입력하고 탭을 두번 누르면 자동으로 속성코드를 만든다.
 */
