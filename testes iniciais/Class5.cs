using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro
{
    class ConversorDeMoeda
    {
        public double Dolar;
        public double Valor;

        public double Total()
        {
            return ((0.06 * Valor)+Valor) * Dolar ;

        }



    }
}
