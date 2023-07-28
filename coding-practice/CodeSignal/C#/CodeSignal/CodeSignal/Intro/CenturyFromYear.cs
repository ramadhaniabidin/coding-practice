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
            int century = (year + 99) / 100;
            return century;
        }
    }
}
