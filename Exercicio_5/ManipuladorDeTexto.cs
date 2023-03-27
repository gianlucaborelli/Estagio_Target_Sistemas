using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    public class ManipuladorDeTexto
    {
        public static string InverterTexto (string texto)
        {
            string textoInvertido = string.Empty;

            for (int i = texto.Length - 1; i >= 0; i--)
            {
                textoInvertido += texto[i];
            }

            return textoInvertido;
        }
    }
}
