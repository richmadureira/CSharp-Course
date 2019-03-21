using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cliente gabriela = new Cliente();

            // gabriela.nome = "Gabriela";
            // gabriela.profissao = "Desenvolvedora C#";
            // gabriela.cpf = "434.562.878-20";

            ContaCorrente conta = new ContaCorrente();

            // conta.titular = gabriela;
            conta.Titular = new Cliente();
            conta.Titular.nome = "Gabriela Costa";
            conta.Titular.cpf = "434.562.878-20";
            conta.Titular.profissao = "Desenvolvedora C#";

            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            // Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.Titular.nome);
            Console.WriteLine(conta.Titular.cpf);
            Console.WriteLine(conta.Titular.profissao);

            Console.ReadLine();

        }
    }
}
