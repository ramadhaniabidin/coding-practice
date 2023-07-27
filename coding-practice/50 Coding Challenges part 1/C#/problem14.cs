// coding challenge 14 : print the first 10 Fibonacci numbers without using recursion
using System;
class problem14
{
    static void print_fibonacci(int n_fibonacci){
        int f0 = 0;
        Console.Write(f0+" ");
        int f1 = 1;
        Console.Write(f1+" ");
        
        for(int i=2; i<n_fibonacci; i++){
            int fi = f1 + f0;
            Console.Write(fi+" ");
            f0 = f1;
            f1 = fi;
        }
    }

    static void Main(string[] args){
        int n_fibonacci = 10;
        print_fibonacci(n_fibonacci);
    }
}