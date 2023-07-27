// coding challenge 5 : calculate the sum of numbers from 1 to 10
using System;

class problem5
{
    static void Main(string[] args){
        int sum = 0, length = 10;
        for (int i = 0; i <= length; i++)
        {
            sum += i;
        }
        Console.Write("The sum of numbers from 1 to 10 is " + sum);
    }
}