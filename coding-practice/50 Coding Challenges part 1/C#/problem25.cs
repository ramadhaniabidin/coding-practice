/* Coding challenge #25
Create a function that will receive two arrays of numbers as arguments 
and return an array composed of all the numbers that are either
in the first array or second array but not in both */

using System;
class problem25
{
    static int[] exclusive_array(int[] array1, int[] array2){
        int[] output = new int[array1.Length+array2.Length];
        int count = 0;
        for(int i=0; i<array1.Length; i++){
            bool found = false;
            for(int j=0; j<array2.Length; j++){
                if(array1[i] == array2[j]){
                    found = true;
                    break;
                }
            }
            if(!found){
                output[count] = array1[i];
                count++;
            }

        }

        for(int i=0; i<array2.Length; i++){
            bool found = false;
            for(int j=0; j<array1.Length; j++){
                if(array2[i] == array1[j]){
                    found = true;
                    break;
                }
            }
            if(!found){
                output[count] = array2[i];
                count++;
            }
        }

        Array.Resize(ref output, count);
        return output;
    }

    static void Main(string[] args){
        int[] array1 = {1, 2, 3, 10, 5, 3, 14};
        int[] array2 = {1, 4, 5, 6, 14};
        int[] exclusive = exclusive_array(array1, array2);
        Console.Write(string.Join(", ", exclusive));
    }
}