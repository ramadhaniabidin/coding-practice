using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class Problem13
    {
        public Dictionary<char, int> romanValues = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

        public int romanToInt(string roman)
        {
            int total = 0;
            int i = 0;
            foreach (char c in roman)
            {
                int current_value = romanValues[c];
                if (i + 1 == roman.Length)
                {
                    total += current_value;
                }
                else if (roman[i] == 'I' && (roman[i + 1] == 'V' || roman[i + 1] == 'X'))
                {
                    total -= 1;
                }
                else if (roman[i] == 'X' && (roman[i + 1] == 'L' || roman[i + 1] == 'C'))
                {
                    total -= 10;
                }
                else if (roman[i] == 'C' && (roman[i + 1] == 'D' || roman[i + 1] == 'M'))
                {
                    total -= 100;
                }
                else
                {
                    total += current_value;
                }
                i++;
            }
            return total;
        }
    }
}
