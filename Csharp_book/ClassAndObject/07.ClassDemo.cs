using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    class Demo
    {
        static void Main()
        {
            ClassOne.Hi();
            ClassTwo.Hi();

            ClassTwo ct = new ClassTwo();
            ct.Hello();
        }
    }
}
