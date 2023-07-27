// coding challenge 13 : find the maximum numbers in an array of numbers
using System;
class problem13
{
    static int find_max(int[] input){
        int max = input[0];
        for(int i=1; i<input.Length; i++){
            if(input[i]>max){
                max = input[i];
            }
        }
        return max;
    }

    static void Main(string[] args){
        int[] input = {-5, 10, -3, 12, 9, 10, -1, -2, -4, 6};
        int max = find_max(input);
        Console.Write("The maximum number in ["+string.Join(", ",input)+"] is "+max);
    }
}