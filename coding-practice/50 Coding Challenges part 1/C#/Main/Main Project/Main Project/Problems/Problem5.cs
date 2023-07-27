using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.Problems
{
    // coding challenge 5 : calculate the sum of numbers from 1 to 10
    public class Problem5
    {
        public void Main()
        {
            int sum = 0, length = 10;
            for (int i = 0; i <= length; i++)
            {
                sum += i;
            }
            Console.Write("The sum of numbers from 1 to 10 is " + sum);
        }
    }
}
