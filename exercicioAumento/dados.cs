using System;
using System.Collections.Generic;
using System.Text;

namespace exercicioAumento
{
    public class Funcionario
    {
        public int id { get; set; }

        public 

        public string nome { get; set; }
        private double salario { get; set; }

        public void setSalario( double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return this.salario;
        }

    }
}
