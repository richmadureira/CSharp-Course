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

            contadoBruno.Depositar(500);
            Console.WriteLine(contadoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno: " + contadoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

            contadoBruno.Transferir(200, contaDaGabriela);
            Console.WriteLine("Foi transferido 200 da Conta do Bruno pra Gabriela ");
            Console.WriteLine("Saldo do Bruno: " + contadoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

            Console.ReadLine();

        }
    }
}
