using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliquotaifs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ex aliquotas com uso de IFs");

            double Salario = 3300.00;

            if (Salario > 1900 && Salario <= 2800)
            {
                Salario = Salario - 142;
            }
            
            if (Salario > 2800 && Salario <= 3751)
            {
                Salario = Salario - 350;
            }
            
            if (Salario > 3751.01 && Salario <= 4664)
            {
                Salario = Salario - 636;
            }

            Console.WriteLine(Salario);
            


            Console.ReadLine();
        }
    }
}
