// challenge 2 : print the odd numbers less than 100
using System;

class problem2
{
    static void Main(string[] args){
        for (int i = 0; i < 100; i++)
        {
            if (i % 2 == 1){
                Console.WriteLine(i);
            }
        }
    }
}