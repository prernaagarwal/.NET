using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        //Unlike in C++, the array does not include the name of the executable(exe) file.

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Enter any key to exit");
            Console.WriteLine("Number of arguments: " + args.Length);
            foreach(string s in args)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
