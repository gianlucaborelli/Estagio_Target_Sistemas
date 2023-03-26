using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    public class Fibonacci
    {
        public static bool IsFibonacci(int n)
        {
            int a = 0;
            int b = 1;

            while (b < n)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }

            return b == n;
        }
    }
}
