// coding challenge 16 : create a function that will return a boolean specifying if a number is prime
using System;
class problem16
{
    static bool is_prime(int number){
        if (number<2){
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
        int[] numbers = {1, 8, 3, 4, 19, 21, 23, 45};
        for(int i=0; i<numbers.Length; i++){
            Console.WriteLine("Is "+numbers[i]+" prime? : "+is_prime(numbers[i]));
        }
    }
}