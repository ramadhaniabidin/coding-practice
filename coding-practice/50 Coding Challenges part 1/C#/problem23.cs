// Coding challenge #23 : Reverse a string
using System;
using System.Text;

class problem23
{    
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

    static void Main(string[] args)
    {
        string word = "Ramadhani";
        string reversed_word = reverse_string(word);
        Console.Write("The reversed version of " + word + " is : " + reversed_word);
    }
}
