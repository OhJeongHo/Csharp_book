using System;

// Convert.ToString() 메소드는 형식 변환이 가능하면 변환해주지만,
// as 연산자는 반드시 지정한 데이터 형식만 변환하고 그렇지 않으면 null을 저장
namespace Class
{
    class AsDemo
    {
        static void Main()
        {
            object s = "반갑습니다.";
            string r1 = s as string;
            Console.WriteLine($"[1] {r1}");

            object i = 1234;
            string r2 = i as string;
            if (r2 == null)
            {
                Console.WriteLine("[2] null입니다.");
            }

            object i2 = 3456;
            if (i2 is string)
            {
                string r3 = i2 as string;
                Console.WriteLine($"[3] {r3}");
            }
            else
            {
                Console.WriteLine("[3] 변환 불가");
            }

        }
    }
}
