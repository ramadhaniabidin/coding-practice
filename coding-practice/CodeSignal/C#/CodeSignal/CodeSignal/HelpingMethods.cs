using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignal
{
    public class HelpingMethods
    {
        public int AdjacentSum(int[] nums)
        {
            int MaxProduct = int.MinValue;
            int Product;
            for (int i = 0; i < nums.Length; i++)
            {
                if((i+1) != nums.Length)
                {
                    Product = nums[i] * nums[i + 1];
                    MaxProduct = Math.Max(Product, MaxProduct);
                }

            }

            return MaxProduct;
        }
    }
}
