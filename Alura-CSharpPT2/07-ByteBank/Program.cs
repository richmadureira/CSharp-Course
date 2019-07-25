using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 3604231);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contadagabriela = new ContaCorrente(867, 3604230);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            

            Console.ReadLine();

        }
    }
}
