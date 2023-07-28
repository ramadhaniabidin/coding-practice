public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello");
        int year = 1940;
        int mod = year % 100;
        int century = (year + 99) / 100;
        Console.WriteLine($"Year {year} is on the {century}th century");
    }
}