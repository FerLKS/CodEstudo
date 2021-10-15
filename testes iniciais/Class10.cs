using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Primeiro
{
    class funcionarios
    {
        public int ID;
        public string Nome;
        public double Salario;

        public funcionarios(int iD, string nome, double salario)
        {
            ID = iD;
            Nome = nome;
            Salario = salario;
        }

        public void aumento(double porcentagem)
        {
            Salario = Salario + Salario * porcentagem / 100.0;        
        }


        public override string ToString()
        {
            return ID
                + ", " + Nome  + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
