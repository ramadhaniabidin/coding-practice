// coding challenge 10 : calculate the sum of numbers in an array of numbers
using System;
class problem10
{
    static int sum_array(int[] array){
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
    static void Main(string[] args){
        int[] myArray = {2, 3, -1, 5, 7, 9, 10, 15, 95};
        Console.Write("The sum of all elements in myArray is " + sum_array(myArray));

    }
}