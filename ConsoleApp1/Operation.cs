using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Operation
    {
        public void FindingHcf(int a, int b)
        {
            int hcf = 0;

            int j = (a < b) ? a : b;
            for (int i = 1; i <= j; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    hcf = i;
                }
            }
            Console.WriteLine("The HCF of the two numbers are: " + hcf);
            Console.ReadLine();
        }

        public void FindingLCM(int a, int b)
        {
            int x, y;
            int lcm;

            if (a > b)
            {
                x = a;
                y = b;
            }
            else
            {
                x = b;
                y = a;
            }
            for (int i = 1; i <= y; i++)
            {
                if ((x * i) % y == 0)
                {
                    lcm = x * i;
                }
            }
            lcm = y;
            Console.WriteLine("LCM of the 2 numbers is: " + lcm);
            Console.ReadLine();
        }
    }
}
