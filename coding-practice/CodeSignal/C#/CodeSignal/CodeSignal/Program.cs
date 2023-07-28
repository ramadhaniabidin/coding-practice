public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello");
        int year = 19456;
        int mod = year % 100;
        int century;     

        if (mod == 0)
        {
            century = (int)Math.Round((double)year / 100);
            Console.WriteLine($"Year {year} is on the {century}th century");
        }

        else if(mod >= 50)
        {
            century = (int)Math.Round((double)year / 100);
            Console.WriteLine($"Year {year} is on the {century}th century");
        }

        else
        {
            century = (int)(Math.Round((double)year / 100) + 1);
            Console.WriteLine($"Year {year} is on the {century}th century");
        }
    }
}