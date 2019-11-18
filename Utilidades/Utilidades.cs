using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public static class Class1
    {
        public static bool Primo(int n)
        {

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
                
            }
            return true;
        }
    }
}
