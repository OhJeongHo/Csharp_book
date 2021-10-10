using System;

namespace Delegate
{
    class Class1
    {
        delegate double GetAreaPointer(int r);

        static void Main()
        {
            double GetArea(int r) => 3.14 * r * r;

            // 동일한 매개변수와 반환값을 갖는 메소드를 대리자 개체에 담는다.
            GetAreaPointer pointer = GetArea;
            Console.WriteLine(pointer.Invoke(10));
            Console.WriteLine(pointer(10));
        }
    }
}
