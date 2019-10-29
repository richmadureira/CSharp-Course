using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] idades = new int[] {15, 28, 35, 50, 28};

            //idades[0] = 15;
            //idades[1] = 28;
            //idades[2] = 35;
            //idades[3] = 50;
            //idades[4] = 28;
            //idades[5] = 63;

            int acumulador = 0;
            for(int indice = 0; indice < idades.Length; indice++)
            {
                acumulador += idades[indice];
            }

            int media = acumulador / idades.Length;
            Console.WriteLine(media);
            */

            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            lista.Adicionar(new ContaCorrente(346, 24561));
            lista.Adicionar(new ContaCorrente(385, 58464));
            lista.Adicionar(new ContaCorrente(323, 79898));

            Console.ReadLine();
            
        }
    }
}
