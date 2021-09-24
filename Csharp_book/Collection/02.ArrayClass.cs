using System;


namespace Collection
{
    class Class1
    {
        /*
         * Array.Sort() - 배열을 정렬
         * Array.Reverse() - 배열을 역순으로 바꿈
         * Array.ConvertAll() - 배열을 특정 값으로 변환
         */
        static void Main()
        {
            int[] arr = { 3, 2, 1, 4, 5 };
            Array.Sort(arr); // 정렬
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Array.Reverse(arr);
            Console.WriteLine(arr);
        }
    }
}
