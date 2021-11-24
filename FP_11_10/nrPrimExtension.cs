using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_11_10
{
    public static class nrPrimExtension
    {
        public static int estePrim(this int n)
        {
            bool flag = false;
            for (int i = 2; i <= n / 2; i++)
            {
                
                if (n % i == 0)
                {

                    flag = true;
                    
                }
              
                
            }
            if (flag == true)
            {
                Console.WriteLine("Numarul nu este prim");
            }
            else
            {
                Console.WriteLine("Numarul este prim");

            }

            return 0;
        }
    }
}
