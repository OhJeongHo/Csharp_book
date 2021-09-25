using System;
using System.Collections.Generic;

// 제네릭 리스트를 사용해서 배열과 동일한 코드를 작성할 수 있다.
namespace Generic
{
    class Class1
    {
        static void Main()
        {
            // 배열 사용
            int[] arrNumbers = new int[2];
            arrNumbers[0] = 10;
            arrNumbers[1] = 20;
            for (int i = 0; i < arrNumbers.Length; i++)
            {
                Console.WriteLine(arrNumbers[i]);
            }

            // 제네릭 리스트 사용
            List<int> lstNumbers = new List<int>();
            lstNumbers.Add(30);
            lstNumbers.Add(40);
            for (int i = 0; i < lstNumbers.Count; i++)
            {
                Console.WriteLine(lstNumbers[i]);
            }
        }
    }
}
