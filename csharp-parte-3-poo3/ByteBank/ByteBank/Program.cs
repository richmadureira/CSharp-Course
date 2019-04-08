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
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario richard = new Funcionario();
            richard.Nome = "Richard";
            richard.CPF = "457.818.708-06";
            richard.Salario = 2000;

            Diretor alex = new Diretor();
            alex.Nome = "Alex";
            alex.CPF = "283.832.293-03";
            alex.Salario = 5000;

            gerenciador.Registrar(richard);
            gerenciador.Registrar(alex);

            Console.WriteLine("Total de Bonificacao: " + gerenciador.GetBonificacao());
            

            Console.ReadLine();
        }
    }
}
