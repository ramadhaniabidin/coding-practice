using CodeSignal;
using System.Linq;
using System.Text;

public class Program
{

    public static void Main()
    {
        Console.WriteLine("Hello");
        int[] array = { -23, 4, -3, 8, -12 };
        HelpingMethods methods = new HelpingMethods();
        int max = methods.AdjacentSum(array);
        Console.WriteLine($"Maximum product: {max}");   
    }

}