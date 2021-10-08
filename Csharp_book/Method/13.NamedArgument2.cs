using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Class1
    {
        public class Messenger
        {
            public void PrintMessage(string message, string prefix = "", string suffix = "")
            {
                Console.WriteLine($"{message}{prefix}{suffix}");
            }
        }

        static void Main()
        {
            Messenger messenger = new Messenger();
            messenger.PrintMessage("My");

            messenger.PrintMessage(prefix: "Oh", message: "My");

            messenger.PrintMessage(prefix: "Oh", message: "My", suffix: "God");
        }
    }
}
