using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Primeiro
{
    class Banco
    {
        public int NumConta;
        public string Nome;
        public char LetraDep;
        public double ValorInicial = 0;
        public double Saque;
        public double Deposito;
        

        public Banco(int numConta, string nome, char letraDep, double saque, double deposito, double valorinicial)
        {
            NumConta = numConta;
            Nome = nome;
            LetraDep = letraDep;
            Saque = saque;
            Deposito = deposito;
            ValorInicial = valorinicial;
        }

        public Banco(int numConta, string nome, char letraDep)
        {
            NumConta = numConta;
            Nome = nome;
            LetraDep = letraDep;
        }
        public double valorinicial
        {
            get { return deposito; }
        }
        public double deposito
        {
            get { return deposito; }
        }
        public double saque
        {
            get { return saque; }
        }
        public void Vi(double valorinicial)
        {
            ValorInicial  = valorinicial;
        }
        public void RetirarDin(double saque)
        {
            ValorInicial -= saque + 5;
            
        }
        public void AdicionarDin(double deposito)
        {
            ValorInicial += deposito;
        }
        public override string ToString()
        {
            return NumConta + ", Titular: " + Nome.ToString(CultureInfo.InvariantCulture)+ ", Saldo: $ "+ ValorInicial.ToString("F2", CultureInfo.InvariantCulture);
        }




    }
}
