// coding challenge 8 : create a function that converts from Celsius to Fahrenheit
using System;
class problem8
{
    static float celsius_to_fahrenheit(float celsius){
        float fahrenheit = ((celsius*1.8f) + 32f);
        return fahrenheit;
    }
    static void Main(string[] args){
        float celsius = 37.5f;
        Console.Write(celsius + " Celsius is equal to " + celsius_to_fahrenheit(celsius) + " Fahrenheit");
    }
}