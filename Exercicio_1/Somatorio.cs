using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    public class Somatorio
    {
        private static int INDICE = 13, SOMA = 0, K = 0; 
        
        public static int TotalDaSoma()
        {
            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            return SOMA;
        } 
    }
}
