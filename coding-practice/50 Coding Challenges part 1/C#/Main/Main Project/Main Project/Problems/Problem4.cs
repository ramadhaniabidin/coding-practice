using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.Problems
{
    // coding challenge 4 : print the multiplicaion table with numbers from 1 to 10
    public class Problem4
    {
        public void Main()
        {
            Console.WriteLine("Multiplication table with numbers from 1 to 10");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(j + " x " + i + " = " + (i * j) + " \t");
                    if (j % 10 == 0)
                    {
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}
