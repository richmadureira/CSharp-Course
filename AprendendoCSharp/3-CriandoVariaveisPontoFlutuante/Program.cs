using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 3 Criando Variaveis ponto flutuante");

            int salario;
            salario = 1200;

            Console.WriteLine(salario);

            double idade;
            idade = 5.0 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            Console.WriteLine(salario * idade);

            Console.WriteLine("A execução acabou. Tecle Enter para sair. . .");
            Console.ReadLine();


        }
    }
}
