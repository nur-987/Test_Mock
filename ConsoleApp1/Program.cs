using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Question 1
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Operation op = new Operation();
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("Calculating the HCF and LCM");

            Console.WriteLine("What is your first number");
            try
            {
                num1 = Int32.Parse(Console.ReadLine());
            }
            catch(FormatException ex)
            {
                Console.WriteLine($"ERROR! {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR! {ex.Message}");
            }


            Console.WriteLine("What is your second number");

            try
            {
                num2 = Int32.Parse(Console.ReadLine());
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"ERROR! {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR! {ex.Message}");
            }

            op.FindingHcf(num1, num2);

            Console.WriteLine("Lets find th LCM of two numbers.");

            op.FindingLCM(num1, num2);

        }

       
    }
}

