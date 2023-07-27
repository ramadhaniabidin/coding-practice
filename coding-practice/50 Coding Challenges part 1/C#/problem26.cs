/*
Coding challenge #26
Create a function that will receive two arrays and will return an array
with elements that are in the first array but not in the second
*/
using System;
public class problem26
{
    static int[] ExclusiveArray(int[] array1, int[] array2, string array_to_keep){
        int duplicates_count = 0;
        for(int i=0; i<array1.Length; i++){
            for(int j=0; j<array2.Length; j++){
                if(array1[i] == array2[j]){
                    duplicates_count++;
                }
            }
        }

        
        
        int k = 0;
        for(int i=0; i<array1.Length; i++){
            bool duplicate_founded = false;
            for(int j=0; j<array2.Length; j++){
                if(array1[i] == array2[j]){
                    duplicate_founded = true;
                    break;
                }
            }

            if(!duplicate_founded && array_to_keep == "Array1"){
                int[] output = new int[array1.Length - duplicates_count];
                output[k] = array1[i];
                k++;
            }
        }

        for(int i=0; i<array2.Length; i++){
            bool duplicate_founded = false;
            for(int j=0; j<array1.Length; j++){
                if(array2[i] == array1[j]){
                    duplicate_founded = true;
                    break;
                }
            }

            if(!duplicate_founded && array_to_keep == "Array2"){
                int[] output = new int[array2.Length - duplicates_count];
                output[k] = array2[i];
                k++;
            }
        }

        return output;
    }

    static void Main(string[] args){
        int[] array1 = {1, 2, 3, 10, 5, 3, 14};
        int[] array2 = {-1, 4, 5, 6, 14};
        int[] exclusive = ExclusiveArray(array1, array2, array_to_keep: "Array2");
        Console.Write(string.Join(", ", exclusive));
    }
}