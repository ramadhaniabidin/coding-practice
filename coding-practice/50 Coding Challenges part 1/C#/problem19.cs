// coding challenge 19 : Create a function that will return in an array the first "nPrimes" prime numbers greater than a number "startAt"
using System;
class problem19
{   
    static bool is_prime(int number){
        if(number<2){
            return false;
        }

        else if(number==2){
            return true;
        }

        int max_div = (int)Math.Sqrt(number);
        for(int i=0; i<=max_div; i++){
            if(number%2 == 0){
                return false;
            }
        }

        return true;
    }

    static int[] array_prime(int nPrimes, int startAt){
        int[] output = new int[nPrimes];
        int j = 0;
        for(int i=0; i<nPrimes;){
            if((is_prime(j)==true) && (j>startAt)){
                output[i] = j;
                i++;
            }
            j++;
        }
        return output;
    }
    static void Main(string[] args){
        int nPrimes = 5;
        int startAt = 5;
        int[] array = new int[nPrimes];
        array = array_prime(nPrimes, startAt);
        Console.Write("The first "+nPrimes+" prime numbers after "+startAt+" are: ["+string.Join(", ",array)+"]");

    }
}