using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// Question 3
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Checker checker = new Checker();

            Console.WriteLine("Input your sentence to check");
            string str = Console.ReadLine();

            checker.Check(str);

            Console.ReadLine();
        }
    }
}
