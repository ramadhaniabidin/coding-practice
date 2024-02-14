using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingProblems
{
    public class DailyProblem
    {
        public void productList(List<int> inputList)
        {
            List<int> result = new List<int>();
            foreach (int input in inputList)
            {
                int resultItem = 1;
                for(int i = inputList.Count - 1 ; i >= 0; i--)
                {
                    if(input != inputList[i])
                    {
                        resultItem *= inputList[i];
                    }
                }
                result.Add(resultItem);
                resultItem = 1;
            }

            Console.WriteLine($"The original array: [{string.Join(", ", inputList)}]");
            Console.WriteLine($"The product array: [{string.Join(", ", result)}]");
        }
    }
}
