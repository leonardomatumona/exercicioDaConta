using System;

namespace exercicioAumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario novofuncionario = new Funcionario()
            {
                id = 333,
                nome = "Maria Brown",
                salario = 4000.00,

            };
            Console.WriteLine("Quantos funcionários serão registrados?");

            int perguntaDeposito = int.Parse(Console.ReadLine());
            if (perguntaDeposito == 3);



        }
    }
}