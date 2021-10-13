using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Class1
    {
        static IEnumerable<int> FindNumbers(Predicate<int> predicate)
        {
            for (int i = 0; i <= 100 ; i++)
            {
                if (predicate(i))
                {
                    yield return i;
                }
            }
        }


        static void Main()
        {
            Predicate<string> isNullOrEmpty = string.IsNullOrEmpty;
            Console.WriteLine(isNullOrEmpty("Not Null"));

            Predicate<Type> isPrimitive = t => t.IsPrimitive;
            Console.WriteLine(isPrimitive(typeof(int)));

            var numbers = FindNumbers(f => f % 33 == 0);
            Console.WriteLine(numbers);
        }
    }
}
