// coding challenges 11 : calculate the average of the numbers in an array of numbers
using System;
class problem11
{
    static float average_array(int[] array){
        float sum = 0f;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum/array.Length;
    }
    static void Main(string[] args){
        int[] array = {1, 3, 9, 15, 90};
        float average = average_array(array);

        Console.Write("The average of this array is " + average);
    }
}