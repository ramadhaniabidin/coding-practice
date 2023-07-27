// Coding challenge #22 : Reverse an array
using System;
class problem22
{
    static int[] reverse_array(int[] input){
        int len = input.Length;
        int[] output = new int[len];
        for(int i=0; i<len; i++){
            output[i] = input[(len-i)-1];
        }

        return output;
    }

    static void Main(string[] args){
        int[] array = {1, 2, 3, 4, 5, 6};
        int[] reversed = new int[array.Length];
        reversed = reverse_array(array);
        Console.Write("The reversed version of ["+string.Join(", ",array)+"] is: ["+string.Join(", ",reversed)+"]");
    }
}