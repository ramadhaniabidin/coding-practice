// coding challenge 6 : calculate 10!
using System;
class problem6
{
    static void Main(string[] args){
        int sum = 1;
        for (int i = 1; i <= 10; i++)
        {
            sum *= i;
        }
        Console.Write("The value of 10! is " + sum);
    }
}