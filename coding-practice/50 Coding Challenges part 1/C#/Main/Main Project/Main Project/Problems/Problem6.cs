using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.Problems
{
    // coding challenge 6 : calculate 10!
    public class Problem6
    {
        public void Main()
        {
            int sum = 1;
            for (int i = 1; i <= 10; i++)
            {
                sum *= i;
            }
            Console.Write("The value of 10! is " + sum);
        }
    }
}
