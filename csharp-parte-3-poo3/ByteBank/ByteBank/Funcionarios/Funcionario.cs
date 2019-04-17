using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
<<<<<<< HEAD
        public static int TotalDeFuniconarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; set; }

       
        public Funcionario(double salario, string cpf)
        {
            CPF = cpf;
            Salario = salario;
            TotalDeFuniconarios++;
            Console.WriteLine("Criando Funcionario");
            TotalDeFuncionarios++;
        }

        public virtual void AumentarSalario()
        {
            Salario *= 1.1;
        }              

        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
