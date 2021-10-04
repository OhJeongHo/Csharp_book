using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 생성자도 메소드임.
// 모든 클래스는 적어도 생성자 하나를 갖는다.
// 사용하지 않는 기본 생성자는 코드에서 생략할 수 있다.
// 생성자는 void를 포함한 반환값을 가지지 않는다.

class Student
{
    public Student()
    {
        Console.WriteLine("Student 개체가 생성되었습니다.");
    }
}

class ConstructorMethod
{
    static void Main()
    {
        Student student;
        student = new Student();    // 생성자로 개체 생성
    }
}