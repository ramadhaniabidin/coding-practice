using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project
{
    public class HelpingMethods
    {

        public float celsius_to_fahrenheit(float celsius)
        {
            float fahrenheit = ((celsius * 1.8f) + 32f);
            return fahrenheit;
        }

        public float fahrenheit_to_celsius(float fahrenheit)
        {
            float celsius = (fahrenheit - 32f) / 1.8f;
            return celsius;
        }

        public int sum_array(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        public float average_array(int[] array)
        {
            float sum = 0f;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }

        public int[] positive_array(int[] input)
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

        public int find_max(int[] input)
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

        public void print_fibonacci(int n_fibonacci)
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

        public int fibonacci(int n_fibonacci)
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

        public bool is_prime(int number)
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

        public int sum_digits(int number)
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

        public int[] array_prime(int nPrimes, int startAt)
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

        public int[] rotate_array(int[] input_array)
        {
            int[] output = new int[input_array.Length];
            output[0] = input_array[input_array.Length - 1];
            for (int i = 1; i < input_array.Length; i++)
            {
                output[i] = input_array[i - 1];
            }
            return output;
        }

        public int[] rotate_right(int[] input)
        {
            int[] output = new int[input.Length];
            for (int i = 0; i < input.Length - 1; i++)
            {
                output[i] = input[i + 1];
            }
            output[input.Length - 1] = input[0];
            return output;
        }

        public int[] reverse_array(int[] input)
        {
            int len = input.Length;
            int[] output = new int[len];
            for (int i = 0; i < len; i++)
            {
                output[i] = input[(len - i) - 1];
            }

            return output;
        }

        public string reverse_string(string input)
        {
            int len = input.Length;
            StringBuilder output = new StringBuilder(len);
            for (int i = 0; i < len; i++)
            {
                output.Append(input[(len - 1) - i]);
            }
            return output.ToString();
        }

        public int[] merge_array(int[] array1, int[] array2)
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

        public int[] exclusive_array(int[] array1, int[] array2)
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

        public int[] ExclusiveArray(int[] array1, int[] array2, string array_to_keep)
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

        public int[] DistinctArray(int[] array)
        {
            Dictionary<int, int> keyValues = new();
            List<int> keys = new();
            foreach (int i in array)
            {
                if (keyValues.ContainsKey(i))
                {
                    keyValues[i]++;
                }
                else
                {
                    keyValues[i] = 1;
                }
            }

            foreach(KeyValuePair<int, int> pair in keyValues)
            {
                keys.Add(pair.Key);
            }

            return keys.ToArray();
        }
    }
}
