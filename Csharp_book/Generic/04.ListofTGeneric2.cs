using System;
using System.Collections.Generic;


namespace Generic
{
    class Class1
    {
        static void Main()
        {
            List<string> colors = new List<string>();

            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Blue");

            for (int i = 0; i < colors.Count; i++)
            {
                Console.Write($"{colors[i]}\t");
            }
            foreach (var color in colors)
            {
                Console.Write($"{color}\t");
            }
        }
    }
}
