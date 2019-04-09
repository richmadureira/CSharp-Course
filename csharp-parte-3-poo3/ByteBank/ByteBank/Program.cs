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

            Funcionario richard = new Funcionario("283.832.293-03");
            richard.Nome = "Richard";            
            richard.Salario = 2000;

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Diretor alex = new Diretor("283.832.293-03");
            alex.Nome = "Alex";
            //alex.CPF = ;
            alex.Salario = 5000;

            Console.WriteLine(Funcionario.TotalDeFuncionarios); 

            gerenciador.Registrar(richard);
            gerenciador.Registrar(alex);

            Console.WriteLine(richard.Nome);
            Console.WriteLine(richard.GetBonificacao());
            Console.WriteLine(alex.Nome);
            Console.WriteLine(alex.GetBonificacao());
            Console.WriteLine("Total de Bonificacao: " + gerenciador.GetBonificacao());
            

            Console.ReadLine();
        }
    }
}
