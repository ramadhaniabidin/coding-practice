﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project
{
    public class AllProblems
    {
        static float celsius_to_fahrenheit(float celsius)
        {
            float fahrenheit = ((celsius * 1.8f) + 32f);
            return fahrenheit;
        }

        static float fahrenheit_to_celsius(float fahrenheit)
        {
            float celsius = (fahrenheit - 32f) / 1.8f;
            return celsius;
        }

        static int sum_array(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        static float average_array(int[] array)
        {
            float sum = 0f;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }

        static int[] positive_array(int[] input)
        {
            int sum_positives = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 0)
                {
                    sum_positives++;
                }
            }
            int[] output = new int[sum_positives];
            int j = 0;
            for (int i = 0; i < sum_positives;)
            {
                if (input[j] > 0)
                {
                    output[i] = j;
                    i++;
                }
                j++;
            }
            return output;

        }

        static int find_max(int[] input)
        {
            int max = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] > max)
                {
                    max = input[i];
                }
            }
            return max;
        }

        static void print_fibonacci(int n_fibonacci)
        {
            int f0 = 0;
            Console.Write(f0 + " ");
            int f1 = 1;
            Console.Write(f1 + " ");

            for (int i = 2; i < n_fibonacci; i++)
            {
                int fi = f1 + f0;
                Console.Write(fi + " ");
                f0 = f1;
                f1 = fi;
            }
        }

        static int fibonacci(int n_fibonacci)
        {
            if (n_fibonacci == 0)
            {
                return 0;
            }
            else if (n_fibonacci == 1)
            {
                return 1;
            }
            return (fibonacci(n_fibonacci - 1) + fibonacci(n_fibonacci - 2));
        }

        static bool is_prime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            else if (number == 2)
            {
                return true;
            }

            int max_div = (int)Math.Sqrt(number);
            for (int i = 2; i <= max_div; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;

        }

        static int sum_digits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int increment = number % 10; // get the last digit of number by taking the remainder when dividing by 10
                sum += increment; // add increment to the sum
                number = number / 10;
            }
            return sum;
        }

        static int[] array_prime(int nPrimes, int startAt)
        {
            int[] output = new int[nPrimes];
            int j = 0;
            for (int i = 0; i < nPrimes;)
            {
                if ((is_prime(j) == true) && (j > startAt))
                {
                    output[i] = j;
                    i++;
                }
                j++;
            }
            return output;
        }

        static int[] rotate_array(int[] input_array)
        {
            int[] output = new int[input_array.Length];
            output[0] = input_array[input_array.Length - 1];
            for (int i = 1; i < input_array.Length; i++)
            {
                output[i] = input_array[i - 1];
            }
            return output;
        }

        static int[] rotate_right(int[] input)
        {
            int[] output = new int[input.Length];
            for (int i = 0; i < input.Length - 1; i++)
            {
                output[i] = input[i + 1];
            }
            output[input.Length - 1] = input[0];
            return output;
        }

        static int[] reverse_array(int[] input)
        {
            int len = input.Length;
            int[] output = new int[len];
            for (int i = 0; i < len; i++)
            {
                output[i] = input[(len - i) - 1];
            }

            return output;
        }

        static string reverse_string(string input)
        {
            int len = input.Length;
            StringBuilder output = new StringBuilder(len);
            for (int i = 0; i < len; i++)
            {
                output.Append(input[(len - 1) - i]);
            }
            return output.ToString();
        }

        static int[] merge_array(int[] array1, int[] array2)
        {
            int len1 = array1.Length;
            int len2 = array2.Length;
            int len = len1 + len2;
            int[] output = new int[len];
            int j = 0;

            for (int i = 0; i < len1; i++)
            {
                output[i] = array1[i];
            }

            for (int i = len1; i < len;)
            {
                output[i] = array2[j];
                i++;
                j++;
            }

            return output;
        }

        static int[] exclusive_array(int[] array1, int[] array2)
        {
            int[] output = new int[array1.Length + array2.Length];
            int count = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    output[count] = array1[i];
                    count++;
                }

            }

            for (int i = 0; i < array2.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array2[i] == array1[j])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    output[count] = array2[i];
                    count++;
                }
            }

            Array.Resize(ref output, count);
            return output;
        }

        static int[] ExclusiveArray(int[] array1, int[] array2, string array_to_keep)
        {
            int duplicates_count = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        duplicates_count++;
                    }
                }
            }


            int k = 0;
            if (array_to_keep == "Array1")
            {
                int[] output = new int[array1.Length - duplicates_count];
                for (int i = 0; i < array1.Length; i++)
                {
                    bool duplicate_founded = false;
                    for (int j = 0; j < array2.Length; j++)
                    {
                        if (array1[i] == array2[j])
                        {
                            duplicate_founded = true;
                            break;
                        }
                    }

                    if (!duplicate_founded)
                    {
                        //int[] output = new int[array1.Length - duplicates_count];
                        output[k] = array1[i];
                        k++;
                    }

                }
                return output;
            }

            else
            {
                int[] output = new int[array2.Length - duplicates_count];
                for (int i = 0; i < array2.Length; i++)
                {
                    bool duplicate_founded = false;
                    for (int j = 0; j < array1.Length; j++)
                    {
                        if (array2[i] == array1[j])
                        {
                            duplicate_founded = true;
                            break;
                        }
                    }

                    if (!duplicate_founded)
                    {
                        //int[] output = new int[array2.Length - duplicates_count];
                        output[k] = array2[i];
                        k++;
                    }
                }
                return output;
            }
        }

        public void Problem1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void Problem2()
        {
            // challenge 2 : print the odd numbers less than 100
            Console.WriteLine("Odd numbers less than 100: ");
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void Problem3()
        {
            // challenge 3 : print the multiplication table with 7
            Console.WriteLine("Multiplication table with 7: ");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("7 x " + i + " = " + 7 * i);
            }
        }

        public void Problem4()
        {
            // coding challenge 4 : print the multiplicaion table with numbers from 1 to 10
            Console.WriteLine("Multiplication table with numbers from 1 to 10");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(j + " x " + i + " = " + (i * j) + " \t");
                    if (j % 10 == 0)
                    {
                        Console.WriteLine("");
                    }
                }
            }
        }

        public void Problem5()
        {
            // coding challenge 5 : calculate the sum of numbers from 1 to 10
            int sum = 0, length = 10;
            for (int i = 0; i <= length; i++)
            {
                sum += i;
            }
            Console.Write("The sum of numbers from 1 to 10 is " + sum);
        }

        public void Problem6()
        {
            // coding challenge 6 : calculate 10!
            int sum = 1;
            for (int i = 1; i <= 10; i++)
            {
                sum *= i;
            }
            Console.Write("The value of 10! is " + sum);
        }

        public void Problem7()
        {
            // coding challenge 7 : calculate the sum of odd numbers greater than 10 and less or equal to 30
            int sum = 0;
            for (int i = 10; i <= 30; i++)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                }
            }
            Console.WriteLine("The sum of odd numbers greater than 10 and less or equal to 30 is " + sum);
        }

        public void Problem8()
        {
            // coding challenge 8 : create a function that converts from Celsius to Fahrenheit
            float celsius = 37.5f;
            Console.Write($"{celsius} Celsius is equal to {celsius_to_fahrenheit(celsius)} Fahrenheit");
        }

        public void Problem9()
        {
            // coding challenge 9 : create a function that converts from Fahrenheit to Celsius
            float fahrenheit = 40f;
            Console.WriteLine($"{fahrenheit} Fahrenheit is equal to {fahrenheit_to_celsius(fahrenheit)} Celsius");
        }

        public void Problem10()
        {
            // coding challenge 10 : calculate the sum of numbers in an array of numbers
            int[] myArray = { 2, 3, -1, 5, 7, 9, 10, 15, 95 };
            Console.Write($"The sum of all elements in myArray is {sum_array(myArray)}");
        }

        public void Problem11()
        {
            // coding challenges 11 : calculate the average of the numbers in an array of numbers
            int[] array = { 1, 3, 9, 15, 90 };
            float average = average_array(array);
            Console.Write("The average of this array is " + average);
        }

        public void Problem12()
        {
            /* coding challenge 12 : create a function that receives an array of numbers and return an array containing
               only the positive numbers */
            int[] array = { -5, 10, -3, 12, 9, 10, -1, -2, -4, 6 };
            int sum_positives = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum_positives++;
                }
            }

            int[] output = new int[sum_positives];
            output = positive_array(array);
            Console.Write("The array with its positive elemnts only [" + string.Join(", ", output) + "]");
        }

        public void Problem13()
        {
            // coding challenge 13 : find the maximum numbers in an array of numbers
            int[] input = { -5, 10, -3, 12, 9, 10, -1, -2, -4, 6 };
            int max = find_max(input);
            Console.Write("The maximum number in [" + string.Join(", ", input) + "] is " + max);
        }

        public void Problem14()
        {
            // coding challenge 14 : print the first 10 Fibonacci numbers without using recursion
            int n_fibonacci = 10;
            print_fibonacci(n_fibonacci);
        }

        public void Problem15()
        {
            // coding challenge 15 : create a function that will find the nth Fibonacci numbers using recursion
            int n_fibonacci = 10;
            int[] fibonacci_array = new int[n_fibonacci];
            for (int i = 0; i < n_fibonacci; i++)
            {
                fibonacci_array[i] = fibonacci(i);
            }
            Console.Write("The first " + n_fibonacci + " numbers are [" + string.Join(", ", fibonacci_array) + "]");
        }

        public void Problem16()
        {
            // coding challenge 16 : create a function that will return a boolean specifying if a number is prime
            int[] numbers = { 1, 8, 3, 4, 19, 21, 23, 45 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Is " + numbers[i] + " prime? : " + is_prime(numbers[i]));
            }
        }

        public void Problem17()
        {
            // coding challenge 17 : calculate the sum of digits of a positive integer number
            int number = 123;
            int sum = sum_digits(number);
            Console.Write("The sum of every digits in " + number + " is " + sum);
        }

        public void Problem18()
        {
            // coding challenge 18 : print the first 100 prime numbers
            int n_prime = 100;
            int[] array_prime = new int[n_prime];
            int j = 0;
            for (int i = 0; i < n_prime;)
            {
                if (is_prime(j) == true)
                {
                    array_prime[i] = j;
                    i++;
                }
                j++;
            }
            Console.WriteLine("The first " + n_prime + " prime numbers are:");
            for (int i = 0; i < n_prime; i++)
            {
                Console.WriteLine(array_prime[i]);
            }
        }

        public void Problem19()
        {
            // coding challenge 19 : Create a function that will return in an array the first "nPrimes" prime numbers greater than a number "startAt"
            int nPrimes = 5;
            int startAt = 5;
            int[] array = new int[nPrimes];
            array = array_prime(nPrimes, startAt);
            Console.Write("The first " + nPrimes + " prime numbers after " + startAt + " are: [" + string.Join(", ", array) + "]");
        }

        public void Problem20()
        {
            // coding challenge 20 : Rotate an array to the left 1 position
            int[] array = { 1, 2, 3, 4, 5 };
            int[] rotated_array = new int[array.Length];
            rotated_array = rotate_array(array);
            Console.Write("The rotated version of [" + string.Join(", ", array) + "] is : [" + string.Join(", ", rotated_array) + "]");
        }

        public void Problem21()
        {
            // Coding challenge #21 : Rotate an array to the right 1 position
            int[] array = { 1, 2, 3, 4, 5 };
            int[] output = new int[array.Length];
            output = rotate_right(array);
            Console.Write("The rotated version of [" + String.Join(", ", array) + "] is : [" + String.Join(", ", output) + "]");
        }

        public void Problem22()
        {
            // Coding challenge #22 : Reverse an array
            int[] array = { 1, 2, 3, 4, 5, 6 };
            int[] reversed = new int[array.Length];
            reversed = reverse_array(array);
            Console.Write("The reversed version of [" + string.Join(", ", array) + "] is: [" + string.Join(", ", reversed) + "]");
        }

        public void Problem23()
        {
            // Coding challenge #23 : Reverse a string
            string word = "Ramadhani";
            string reversed_word = reverse_string(word);
            Console.Write("The reversed version of " + word + " is : " + reversed_word);
        }

        public void Problem24()
        {
            // Coding challenge #24 : Create a function that will merge two arrays  and return the result as a new array
            int[] array1 = { 1, 2, 3, 4 };
            int[] array2 = { 4, 5, 6 };
            int[] merge = new int[array1.Length + array2.Length];

            merge = merge_array(array1, array2);
            Console.Write("The merged array of [" + string.Join(", ", array1) + "] and [" + string.Join(", ", array2) + "] is [" + string.Join(", ", merge) + "]");
        }

        public void Problem25()
        {
            /* Coding challenge #25
            Create a function that will receive two arrays of numbers as arguments 
            and return an array composed of all the numbers that are either
            in the first array or second array but not in both */
            int[] array1 = { 1, 2, 3, 10, 5, 3, 14 };
            int[] array2 = { 1, 4, 5, 6, 14 };
            int[] exclusive = exclusive_array(array1, array2);
            Console.Write(string.Join(", ", exclusive));
        }

        public void Problem26()
        {
            /*
            Coding challenge #26
            Create a function that will receive two arrays and will return an array
            with elements that are in the first array but not in the second
            */
            int[] array1 = { 1, 2, 3, 10, 5, 3, 14 };
            int[] array2 = { -1, 4, 5, 6, 14 };
            int[] exclusive = ExclusiveArray(array1, array2, array_to_keep: "Array2");
            Console.WriteLine($"Array 1: {string.Join(", ", array1)}");
            Console.WriteLine($"Array 2: {string.Join(", ", array2)}");
            Console.Write("Exclusive array: "+string.Join(", ", exclusive));
        }


    }

}
