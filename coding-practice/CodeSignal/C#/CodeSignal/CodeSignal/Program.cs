using CodeSignal;
using DailyCodingProblems;
using System.Linq;
using System.Text;

public class Program
{

    public static void Main()
    {
        //Console.WriteLine("Hello");
        //int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9} };
        //int[] array = { 1, 2, 3 };


        ////Console.WriteLine(string.Join(", ", array));


        ////for (int i = 0; i < matrix.GetLength(0); i++)
        ////{
        ////    //for (int j = 0; j < matrix.GetLength(1); j++)
        ////    //{
        ////    //    if ((i + 1) < matrix.GetLength(0))
        ////    //    {
        ////    //        Console.Write($"{matrix[j, i]}, ");
        ////    //    }

        ////    //    else
        ////    //    {
        ////    //        Console.Write($"{matrix[j, i]}\n");
        ////    //    }
        ////    //}

        ////    if ((i + 1) < matrix.GetLength(0))
        ////    {
        ////        Console.Write($"{matrix[0, i]}, ");
        ////    }

        ////    else
        ////    {
        ////        Console.Write($"{matrix[0, i]}\n");
        ////    }

        ////    //j++;
        ////}


        //for (int i = 0; i < matrix.GetLength(1); i++)
        //{
        //    for (int j = 0; j < matrix.GetLength(0); j++)
        //    {
        //        if ((i + 1) < matrix.GetLength(0))
        //        {
        //            Console.Write($"{matrix[j, i]}, ");
        //        }

        //        else
        //        {
        //            Console.Write($"{matrix[j, i]}\n");
        //        }
        //    }

        //    //if ((i + 1) < matrix.GetLength(0))
        //    //{
        //    //    Console.Write($"{matrix[0, i]}, ");
        //    //}

        //    //else
        //    //{
        //    //    Console.Write($"{matrix[0, i]}\n");
        //    //}

        //    //j++;
        //}
        bool isLoop = true;
        int userInput = new int();
        string? userConfirm = "";
        
        while (isLoop)
        {
            Console.WriteLine("Hello, these are my C# coding exercise topics: ");
            Console.Write("1. Code Signal\n" +
                "2. 50 Coding challenges\n" +
                "3. Daily Coding Problem\n\n" +
                "Which one do you want to see? ");
            userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 3)
            {
                DailyProblem dailyProblem = new DailyProblem();
                List<int> list = new List<int> { 1, 2, 3, 4 };
                dailyProblem.productList(list);
                Console.Write("Do you want to stop? (Y/n)?: ");
                userConfirm = Console.ReadLine();
                if((userConfirm.ToLower() == "y") || (userConfirm.ToUpper() == "Y"))
                {
                    isLoop = false;
                }
                else
                {
                    Console.Clear();
                    continue;
                }
            }
            else
            {
                Console.WriteLine("I'm sorry, this menu is not ready yet");
            }
        }
    }

}