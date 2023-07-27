/* coding challenge 12 : create a function that receives an array of numbers and return an array containing
   only the positive numbers */

using System;
class problem12{
    static int[] positive_array(int[] input){
        int sum_positives = 0;
        for(int i=0; i<input.Length; i++){
            if(input[i]>0){
                sum_positives++;
            }
        }
        int[] output = new int[sum_positives];
        int j = 0;
        for(int i=0; i<sum_positives;){
            if(input[j]>0){
                output[i] = j;
                i++;
            }
            j++;
        }
        return output;

    }

    static void Main(string[] args){
        int[] array = {-5, 10, -3, 12, 9, 10, -1, -2, -4, 6};
        int sum_positives = 0;
        for(int i=0; i<array.Length; i++){
            if(array[i]>0){
                sum_positives++;
            }
        }

        int[] output = new int[sum_positives];
        output = positive_array(array);
        Console.Write("The array with its positive elemnts only [" + string.Join(", ",output)+"]");
    }
}