using CodeSignal;
using System.Linq;
using System.Text;

public class Program
{

    public static void Main()
    {
        Console.WriteLine("Hello");
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9} };
        int[] array = { 1, 2, 3 };
        

        //Console.WriteLine(string.Join(", ", array));


        //for (int i = 0; i < matrix.GetLength(0); i++)
        //{
        //    //for (int j = 0; j < matrix.GetLength(1); j++)
        //    //{
        //    //    if ((i + 1) < matrix.GetLength(0))
        //    //    {
        //    //        Console.Write($"{matrix[j, i]}, ");
        //    //    }

        //    //    else
        //    //    {
        //    //        Console.Write($"{matrix[j, i]}\n");
        //    //    }
        //    //}

        //    if ((i + 1) < matrix.GetLength(0))
        //    {
        //        Console.Write($"{matrix[0, i]}, ");
        //    }

        //    else
        //    {
        //        Console.Write($"{matrix[0, i]}\n");
        //    }

        //    //j++;
        //}


        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if ((i + 1) < matrix.GetLength(0))
                {
                    Console.Write($"{matrix[j, i]}, ");
                }

                else
                {
                    Console.Write($"{matrix[j, i]}\n");
                }
            }

            //if ((i + 1) < matrix.GetLength(0))
            //{
            //    Console.Write($"{matrix[0, i]}, ");
            //}

            //else
            //{
            //    Console.Write($"{matrix[0, i]}\n");
            //}

            //j++;
        }
    }

}