// Coding challenge #21 : Rotate an array to the right 1 position
using System;
class problem21
{
    static int[] rotate_right(int[] input){
        int[] output = new int[input.Length];
        for(int i=0; i<input.Length-1; i++){
            output[i] = input[i+1];
        }
        output[input.Length-1] = input[0];
        return output;
    }

    static void Main(string[] args){
        int[] array = {1, 2, 3, 4, 5};
        int[] output = new int[array.Length];
        output = rotate_right(array);
        Console.Write("The rotated version of ["+String.Join(", ",array)+"] is : ["+String.Join(", ", output)+"]");
    }
}