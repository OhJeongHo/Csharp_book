using System;

// Execption 클래스는 Message 속성으로 예외 내용을 알려줌.
namespace Exception_handling
{
    class Class1
    {
        static void Main()
        {
            try
            {
                int[] arr = new int[2];
                arr[100] = 1234;
            }
            // 일반적으로 catch 절의 형태는 e 또는 ex 변수로 사용.
            catch(Exception ex) // ex 변수에는 상세한 예외 정보가 담김
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
