using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 클래스도 데이터 형식의 하나이므로 배열처럼 사용할 수 있다.
// 특정 클래스 형식을 배열로 선언한 후 각 배열의 인스턴스를 생성하여 사용해보기.

public class CategoryClass
{
    public void Print(int i) => Console.WriteLine($"카테고리 {i}");
}

class ClassArray
{
    static void Main()
    {
        CategoryClass[] categories = new CategoryClass[3];  // 1. 클래스 배열 생성

        // 2. 각 요소에 인스턴스 생성
        categories[0] = new CategoryClass();
        categories[1] = new CategoryClass();
        categories[2] = new CategoryClass();

        for (int i = 0; i < categories.Length; i++)
        {
            categories[i].Print(i);
        }
    }
}
