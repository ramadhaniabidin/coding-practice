// coding challenge 17 : calculate the sum of digits of a positive integer number
using System;
class problem17
{
    static int sum_digits(int number){
        int sum = 0;
        while(number>0){
            int increment = number%10; // get the last digit of number by taking the remainder when dividing by 10
            sum += increment; // add increment to the sum
            number = number/10;
        }
        return sum;
    }
    static void Main(string[] args){
        int number = 123;
        int sum = sum_digits(number);
        Console.Write("The sum of every digits in "+number+" is "+sum);
    }
}