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

            Funcionario richard = new Funcionario(2000, "457.818.708-06");
            richard.Nome = "Richard";
            // richard.CPF = "457.818.708-06";
            //richard.Salario = 2000;

            richard.AumentarSalario();
            Console.WriteLine("Novo Salario de Richard: " + richard.Salario);

            Diretor alex = new Diretor("283.832.293-03");
            alex.Nome = "Alex";
            //alex.CPF = "283.832.293-03";
            //alex.Salario = 5000;

            alex.AumentarSalario();
            Console.WriteLine("Novo Salario de Alex: " + alex.Salario);

            Funcionario Alexteste = alex;

            Console.WriteLine("Bonificacao de uma referencia de Diretor: " + alex.GetBonificacao());
            Console.WriteLine("Bonificacao de uma referencia  de funcionario: " + Alexteste.GetBonificacao());

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
