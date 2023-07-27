/*
Coding challenge #27a : Create a function that will receive an array of
numbers as argument and will return a new array with distinct elements
*/

using System;
class problem27
{
    static Tuple<int[], int[]> DuplicatedElements(int[] input){
        int count_duplicates = 0;
        for(int i=0; i<input.Length; i++){
            for(int j=i+1; j<input.Length; j++){
                if(input[i] == input[j]){
                    count_duplicates++;
                }
            }
        }

        int[] duplicated_elements = new int[count_duplicates]; // This will store the duplicated elements in an array
        int[] duplicated_index = new int[count_duplicates]; // This code stores the index of the duplicated elements
        int[] duplicates_removed = new int[input.Length - count_duplicates]; // This code stores the array without duplicated elements

        int k=0;
        for(int i=0; i<input.Length; i++){
            for(int j=i+1; j<input.Length; j++){
                if(input[i] == input[j]){
                    duplicated_elements[k] = input[i];
                    duplicated_index[k] = j;
                    k++;
                }
            }
        }

        for(int i=0; i<input.Length - count_duplicates;){
            foreach
        }

        return Tuple.Create(duplicated_elements, duplicated_index);
    }

    static void Main(string[] args){
        int[] array = { 1, 2, 5, 2, 3, 0, 4, 5, 6, 10, 1, 0 };
        Tuple<int[], int[]> result = DuplicatedElements(array);
        int[] duplicate = result.Item1;
        int[] duplicate_index = result.Item2;
        Console.WriteLine("Original array : ["+string.Join(", ", array)+"]");
        Console.WriteLine("Duplicated elements : ["+string.Join(", ", duplicate)+"]");
        Console.WriteLine("Index of duplicated elements : ["+string.Join(", ", duplicate_index)+"]");
    }
}