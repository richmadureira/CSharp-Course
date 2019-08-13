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
            string url = "pagina?argumentos";

            int indiceInterrogacao = url.IndexOf('?');

            //Console.WriteLine(indiceInterrogacao);

            string argumentos = url.Substring(indiceInterrogacao+1);
            Console.WriteLine(argumentos);

            Console.ReadLine();
        }
    }
}
