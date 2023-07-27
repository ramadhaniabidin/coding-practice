// coding challenge 15 : create a function that will find the nth Fibonacci numbers using recursion
using System;
class problem15
{
    static int fibonacci(int n_fibonacci){
        if(n_fibonacci==0){
            return 0;
        }
        else if(n_fibonacci==1){
            return 1;
        }
        return (fibonacci(n_fibonacci-1) + fibonacci(n_fibonacci-2));
    }

    static void Main(string[] args){
        int n_fibonacci = 10;
        int[] fibonacci_array = new int[n_fibonacci];
        for(int i=0; i<n_fibonacci; i++){
            fibonacci_array[i] = fibonacci(i);
        }
        Console.Write("The first "+n_fibonacci+" numbers are ["+string.Join(", ",fibonacci_array)+"]");
    }
}