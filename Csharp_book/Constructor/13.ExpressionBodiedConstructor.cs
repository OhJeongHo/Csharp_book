using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 생성자를 사용하면 클래스 기본값을 설정하고 인스턴스화 되는 개체에 제약 둘 수 있고,
// 읽기 쉬운 코드도 작성할 수 있다.

// 필드처럼 private 액세스 한정자를 가진 맴버들은
// 생성자로 초기화해서 사용할 수 있다.

class Pet
{
    private string _name;
    public Pet(string name) => _name = name;    // 식 본문 생성자
    public override string ToString()
    {
        return _name;
    }
}

class Test
{
    static void Main()
    {
        var pet = new Pet("야옹이");
        Console.WriteLine(pet.ToString());
    }
}
