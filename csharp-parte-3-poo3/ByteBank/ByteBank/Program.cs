using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario Carlos = new Funcionario(1);

            Carlos.Nome = "Carlos";
            Carlos.CPF = "457.818.708-06";
            Carlos.Salario = 2000;


            Console.WriteLine(Carlos.Nome);
            Console.WriteLine(Carlos.GetBonificacao());

            Console.ReadLine();
        }
    }
}
