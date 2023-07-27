// coding challenge 20 : Rotate an array to the left 1 position
using System;
class problem20
{
    static int[] rotate_array(int[] input_array){
        int[] output = new int[input_array.Length];
        output[0] = input_array[input_array.Length-1];
        for(int i=1; i<input_array.Length; i++){
            output[i] = input_array[i-1];
        }
        return output;
    }

    static void Main(string[] args){
        int[] array = {1, 2, 3, 4, 5};
        int[] rotated_array = new int[array.Length];
        rotated_array = rotate_array(array);
        Console.Write("The rotated version of ["+string.Join(", ",array)+"] is : ["+string.Join(", ",rotated_array)+"]");
    }
}