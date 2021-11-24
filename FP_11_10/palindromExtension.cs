using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_11_10
{
    public static class palindromExtension
    {
        public static bool estePalindrom(this int n)
        {

            return n == n.Rasturnat();
        }
        public static int Rasturnat(this int n)
        {
            int r = 0;
            int og = 0;
            while (n != 0)
            {
                r = n % 10;
                n /= 10;
                og = og * 10 + r;

            }
            return og;
        }
    }
}
