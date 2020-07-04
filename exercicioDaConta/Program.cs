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
            };

            Console.WriteLine("Haverá depósito inicial (s/n)?");

            char perguntaDeposito = char.Parse(Console.ReadLine());
            if(perguntaDeposito =='s' || perguntaDeposito == 'S'  || perguntaDeposito == 'N'  || perguntaDeposito == 'n')
            {
                Console.WriteLine("Entre o valor de deposito inicial:");
                Conta1.Depositar(double.Parse(Console.ReadLine()),22);

            }


           
            Console.WriteLine("Nome do Titular:" + Conta1.NomeTitular);
            Console.WriteLine("Numero da Conta:" + Conta1.NumeroConta);

            Console.WriteLine("Saldo Após Deposito:" + Conta1.Depositar(0, Conta1.Saldo));
            

            Conta1.sacar(200, Conta1.Saldo);

            Console.WriteLine("Saldo Após Sacar:" + Conta1.sacar(500, Conta1.Saldo));
            Console.ReadKey();
            
        }
    }
}
