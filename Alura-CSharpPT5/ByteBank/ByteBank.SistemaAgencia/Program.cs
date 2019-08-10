using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContaCorrente conta = new ContaCorrente(374, 3627362);
            //Console.WriteLine(conta.Saldo);

            DateTime dataFimpPagamento = new DateTime(2018, 8, 17);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFimpPagamento - dataCorrente;

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(dataFimpPagamento);
            Console.WriteLine(dataCorrente);
            Console.WriteLine(diferenca);

            Console.WriteLine(mensagem);

            Console.ReadLine();
        }
    }
}
