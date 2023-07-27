// coding challenge 7 : calculate the sum of odd numbers greater than 10 and less or equal to 30
using System;
class problem7
{
    static void Main(string[] args){
        int sum = 0;
        for (int i = 10; i <= 30; i++)
        {
            if (i % 2 == 1){
                sum += i;
            }
        }
        Console.WriteLine("The sum of odd numbers greater than 10 and less or equal to 30 is " + sum);
    }
}