using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignal
{
    public class Intro
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int CenturyFromYear(int year)
        {
            int century = (year + 99) / 100;
            return century;
        }

        public bool CheckPalindrome(string InputString)
        {
            char[] array = InputString.ToCharArray();
            Array.Reverse(array);
            string test = new string(array);
            return InputString == test ? true : false;
        }

        public int AdjacentSum(int[] nums)
        {
            int MaxProduct = int.MinValue;
            int Product;
            for (int i = 0; i < nums.Length; i++)
            {
                if ((i + 1) != nums.Length)
                {
                    Product = nums[i] * nums[i + 1];
                    MaxProduct = Math.Max(Product, MaxProduct);
                }

            }

            return MaxProduct;
        }

        public int ShapeArea(int n)
        {
            int Area = n * n + (n - 1) * (n - 1);
            return Area;
        }


        public int MakeArrayConsecutive2(int[] nums)
        {
            Array.Sort(nums);
            List<int> list = new();
            for(int i = nums.Min(); i <= nums.Max(); i++)
            {
                list.Add(nums[i]);
            }

            return (list.Count - nums.Length);
        }
    }
}
