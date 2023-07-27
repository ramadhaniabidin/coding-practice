using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.Problems
{
    // challenge 3 : print the multiplication table with 7
    public class Problem3
    {
        public void Main()
        {
            Console.WriteLine("Multiplication table with 7: ");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("7 x " + i + " = " + 7 * i);
            }
        }
    }
}
