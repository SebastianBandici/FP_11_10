using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_11_10
{
    public static class divizorExtension
    {
        public static int CatiDivizori(this int n)
        {
            int k = 0;
            for (int i = 2; i <= n / 2; i++)
            {
                
                if (n % i == 0)
                {
                    k++;
                    
                }
            }
            Console.WriteLine($"Numarul {n} are {k} divizori");
            return k;
        }
    }
}
