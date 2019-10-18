using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("слыш,число ввел");

            string S1 = Console.ReadLine();
            int a = int.Parse(S1);

            Console.WriteLine("число два");
            string S2 = Console.ReadLine();
            int b = int.Parse(S2);

            int c = a + b;

            Console.WriteLine(a.ToString() + " + " + b.ToString() + " = " + c.ToString());

            Console.ReadLine();
        }
    }
}
