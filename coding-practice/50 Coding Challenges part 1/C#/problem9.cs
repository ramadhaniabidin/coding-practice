// coding challenge 9 : create a function that converts from Fahrenheit to Celsius
using System;
class problem9
{
    static float fahrenheit_to_celsius(float fahrenheit){
        float celsius = (fahrenheit - 32f)/1.8f;
        return celsius;
    }

    static void Main(string[] args){
        float fahrenheit = 40f;
        Console.WriteLine(fahrenheit + " Fahrenheit is equal to " + fahrenheit_to_celsius(fahrenheit) + " Celsius");
    }

}