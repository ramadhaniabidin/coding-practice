using CodeSignal;
using DailyCodingProblems;
using LeetCode.Easy;
using System.Linq;
using System.Text;

public class Program
{

    public static void Main()
    {
        Problem13 RomanToInt = new();
        string romanString = "MCMXCIV";
        int romanNumber = RomanToInt.romanToInt(romanString);

        Console.WriteLine($"The integer value of {romanString} is {romanNumber}");
    }

}