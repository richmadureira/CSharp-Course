using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ListaDeContaCorrente
    {
        // [item][item][item][item][item]
        //                                ^
        //                                 `- _proximaPosicao

        private ContaCorrente[] _itens;
        private int _proximaPosicao;

        public ListaDeContaCorrente()
        {
            _itens = new ContaCorrente[5];
            _proximaPosicao = 0;
        }

        public void Adicionar(ContaCorrente item)
        {
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
            Console.WriteLine($"Adicionando no índice {_proximaPosicao} conta {item.Agencia}/{item.Numero}");
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            int novoTamanho = _itens.Length * 2;

            if(_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario; 
            }
        }



    }
}
