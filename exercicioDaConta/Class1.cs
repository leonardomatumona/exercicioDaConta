using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{
    class Conta 
    {
        public string NomeTitular { get; set; }
        public int  NumeroConta { get; set; }

        public double Saldo { get; set; }

        public double Depositar( double valor, double saldo)
        {
            if (saldo <= valor)
            {
                saldo += valor;
            }
            return saldo;
        }

        public double sacar(double valor , double saldo)
        {
            if (saldo <= valor)
            {
                saldo -= saldo;
            }
            return saldo;
        }

       
       




    }
}
