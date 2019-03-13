using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contadoBruno = new ContaCorrente();

            contadoBruno.titular = "Bruno";

            Console.WriteLine(contadoBruno.saldo);

            bool resultadoSaque = contadoBruno.Sacar(50);

            Console.WriteLine(contadoBruno.saldo);
            Console.WriteLine(resultadoSaque);


            Console.ReadLine();

        }
    }
}
