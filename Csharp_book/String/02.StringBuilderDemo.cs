using System;
using System.Text;

namespace String
{
    class StringBuilderDemo
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("January\n");
            sb.Append("February\n");
            sb.Append("March");

            Console.WriteLine(sb);
        }
        

    }
}
