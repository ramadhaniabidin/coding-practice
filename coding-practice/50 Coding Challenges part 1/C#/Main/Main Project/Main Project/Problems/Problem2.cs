using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.Problems
{
    // challenge 2 : print the odd numbers less than 100
    public class Problem2
    {
        public void Main()
        {
            Console.WriteLine("Odd numbers less than 100: ");
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
