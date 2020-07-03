using System;
using ContaBancaria;

namespace exercicioDaConta
{
    class Program
    {
        static void Main(string[] args)
        {
            var Conta1 = new Conta()
            {
               NomeTitular = "Luiz Castro Cavalcante",
               NumeroConta = 8532,
               Saldo = 500.0,
            };

            Console.WriteLine("Nome do Titular:" + Conta1.NomeTitular);
            Console.WriteLine("Numero da Conta:" + Conta1.NumeroConta);
            Console.WriteLine("Deposito Inicial:" + Conta1.Saldo);

            Conta1.Depositar(500, Conta1.Saldo);

            Console.WriteLine("Saldo Após Deposito:" + Conta1.Depositar(500, Conta1.Saldo));
            

            Conta1.sacar(200, Conta1.Saldo);

            Console.WriteLine("Saldo Após Sacar:" + Conta1.sacar(200, Conta1.Saldo));
            Console.ReadKey();






        }
    }
}
