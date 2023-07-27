// coding challenge 18 : print the first 100 prime numbers
using System;
class problem18
{
    static bool is_prime(int number){
        if(number<2){
            return false;
        }

        else if(number==2){
            return true;
        }

        int max_div = (int)Math.Sqrt(number);
        for(int i=2; i<=max_div; i++){
            if(number%i == 0){
                return false;
            }
        }
        return true;
    }
    static void Main(string[] args){
        int n_prime = 100;
        int[] array_prime = new int[n_prime];
        int j = 0;
        for(int i=0; i<n_prime;){
            if(is_prime(j) == true){
                array_prime[i] = j;
                i++;
            }
            j++;
        }
        Console.WriteLine("The first "+n_prime+" prime numbers are:");
        for(int i=0; i<n_prime; i++){
            Console.WriteLine(array_prime[i]);
        }

    }
}