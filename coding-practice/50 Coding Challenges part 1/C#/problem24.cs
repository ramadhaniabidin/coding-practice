// Coding challenge #24 : Create a function that will merge two arrays  and return the result as a new array
using System;
class problem24
{
    static int[] merge_array(int[] array1, int[] array2){
        int len1 = array1.Length;
        int len2 = array2.Length;
        int len = len1 + len2;
        int[] output = new int[len];
        int j = 0;

        for(int i=0; i<len1; i++){
            output[i] = array1[i];
        }

        for(int i=len1; i<len;){
            output[i] = array2[j];
            i++;
            j++;
        }

        return output;
    }

    static void Main(string[] args){
        int[] array1 = {1, 2, 3, 4};
        int[] array2 = {4, 5, 6};
        int[] merge = new int[array1.Length + array2.Length];

        merge = merge_array(array1, array2);
        Console.Write("The merged array of ["+string.Join(", ",array1)+"] and ["+string.Join(", ",array2)+"] is ["+string.Join(", ",merge)+"]");
    }
}