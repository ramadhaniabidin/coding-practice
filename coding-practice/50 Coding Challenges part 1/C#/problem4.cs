// coding challenge 4 : print the multiplicaion table with numbers from 1 to 10
using System;

class problem4
{
    static void Main(string[] args){
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write(j + " x " + i + " = " + (i*j) + " \t");
                if (j%10 == 0){
                    Console.WriteLine("");
                }
            }
        }
    }
}