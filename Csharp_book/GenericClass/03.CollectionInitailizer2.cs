using System;
using System.Collections.Generic;

// 제네릭 클래스에 사용자 정의 클래스 사용하기
// List<T> 형태의 T에 사용자 정의 클래스를 매개변수로 사용할 수 있다.
// 다음코드의 1이 컬렉션 이니셜라이저이다.

class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}

class Test
{
    static void Main()
    {
        // 1. 컬렉션 이니셜라이저를 사용하여 카테고리 리스트 만들기
        var categories = new List<Category>()
        {
            new Category() { CategoryId = 1, CategoryName = "좋은 책" },
            new Category() { CategoryId = 2, CategoryName = "좋은 강의" },
            new Category() { CategoryId = 3, CategoryName = "좋은 컴퓨터" },
        };

        // 2. foreach 문으로 컬렉션 데이터를 출력
        foreach (var category in categories)
        {
            Console.WriteLine($"{category.CategoryId} - {category.CategoryName}");
        }
    }
}
