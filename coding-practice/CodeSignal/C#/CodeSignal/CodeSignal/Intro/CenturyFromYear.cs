using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignal.Intro
{
    public class CenturyFromYear
    {
        public int Solution(int year)
        {
            int mod = year % 100;
            int century;

            if (mod == 0)
            {
                century = (int)Math.Round((double)year / 100);
                return century;
            }

            else if (mod >= 50)
            {
                century = (int)Math.Round((double)year / 100);
                return century;
            }

            else
            {
                century = (int)(Math.Round((double)year / 100) + 1);
                return century;
            }
        }
    }
}
