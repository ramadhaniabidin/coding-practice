using CodeSignal;
using System.Linq;
using System.Text;

public class Program
{

    public static void Main()
    {
        Console.WriteLine("Hello");
        int[] statues = { 6, 2, 3, 8};
        Array.Sort(statues);
        List<int> PerfectStatues = new List<int>();
        
        for(int i = statues.Min(); i <= statues.Max(); i++)
        {
            PerfectStatues.Add(i);
            Console.Write(i + ", ");
        }

        Console.WriteLine("\nresult: " + (PerfectStatues.Count - statues.Length));

        //statues.Max();
        //Console.WriteLine(statues.Max());
        //Console.WriteLine(statues.Min());
        //Console.WriteLine(string.Join(", ", statues)); 
    }

}