using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace LINQ
{
    class Class1
    {
        static void Main()
        {
            int[] numbers = { 1, 3, 4 };

            double average = numbers.Average();
            WriteLine($"{nameof(numbers)} 배열 요소의 평균 : {average:#,###.##}");
        }
    }
}
