using System;


namespace Class
{
    class RandomClassDemo_로또
    {
        static void Main()
        {
            Console.WriteLine("이번 주의 로또 : ");

            Random ran = new Random();
            int[] arr = new int[6]; // 데이터 6개
            int temp = 0;

            for (int i = 0; i < 6; i++)
            {
                temp = ran.Next(45) + 1; // 1~45 까지의 랜덤한 숫자 생성
                bool flag = false;
                if (i > 0 && i < 6)
                {
                    for (int j = 0; j <= i; j++)    // i의 첫 반복일떄마다 생성된 숫자가 배열내에 존재하는지 검사
                    {
                        if (arr[j] == temp)
                        {
                            flag = true; // 중복되면 true로 설정
                        }
                    }
                }
                if (flag)
                {
                    --i;    // 중복된 경우 현재 인덱스를 반복
                }
                else
                {
                    arr[i] = temp;  // 중복된 데이터가 없다면 저장
                }
            }

            for (int i = 0; i < 6; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
        }
    }
}
