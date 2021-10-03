using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 필드를 만들고 클래스 외부에서 사용하도록 설정하려면 public 엑세스 한정자를 붙이거나 속성(프로퍼티)으로 변환해야함
 * 
 * 멤버 보이기
 * 엑세스 한정자로 클래스의 맴버에 대한 접근 여부를 적용할 수 있다.
 * 
 * 접근제한자/엑세스 한정자의 종류
 * public : 맴버에 대한 접근이 제한되지 않음. 모든 곳에서 접근이 가능. public이 지정된 클래스 및 맴버는 항상 접근 가능
 * private : 현재 클래스 내에서만 접근 가능.
 * protected : 현재 클래스 또는 현재 클래스를 상속하는 자식 클래스에만 접근이 허가됨.
 * internal : 현재 프로젝트의 모든 클래스에 접근이 허가됨
 * protected internal : 현재 어셈블리 또는 현재 어셈블리에서 파생된 모든 클래스에 엑세스가 허가됨.
 */
namespace Field
{
    class Category
    {
        public string CategoryName;
    }

    class PublicField
    {
        static void Main()
        {
            Category book = new Category();
            book.CategoryName = "책";
            Console.WriteLine(book.CategoryName); // 책
        }
    }
}
