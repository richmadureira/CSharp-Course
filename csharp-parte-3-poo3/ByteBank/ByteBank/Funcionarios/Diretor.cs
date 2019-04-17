using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
<<<<<<< HEAD
        public Diretor( string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando  Diretor"); 
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
       
        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao() ;
=======

        public Diretor(string cpf) : base(cpf)
        {
            Console.WriteLine("Criando Diretor");
        }

        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
>>>>>>> 2f2208b01aed5356009da538bd7a3ef5e847d28b
        }
    }
}
