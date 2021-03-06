using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Class1
    {
        static IEnumerable<int> GetFibonacci()
        {
            int current = 1;
            int next = 1;
            yield return current;
            while (true)
            {
                int temp = current + next;
                current = next;
                next = temp;
                yield return current;
            }
        }

        static void Main()
        {
            int count = 7;
            int i = 0;
            foreach (var f in GetFibonacci())
            {
                Console.WriteLine(f);
                if (++i > count)
                {
                    break;
                }
            }
        }
    }
}
