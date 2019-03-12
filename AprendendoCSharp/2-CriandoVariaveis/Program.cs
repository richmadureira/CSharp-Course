using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 2 - Criando Variaveis");

            int idade;
            idade = 32;
            Console.WriteLine(idade);

            idade = 10 + 5;
            Console.WriteLine(idade);

            Console.WriteLine("Sua idade eh: " + idade + "!");

            Console.WriteLine("execuçao Finalizada. Clique enter para sair. . . ");
            Console.ReadLine();
        }
    }
}
