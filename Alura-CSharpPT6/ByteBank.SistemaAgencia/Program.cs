using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            //string padrao = "[0-9]{4}[-][0-9]{4}";
            //string padrao = "[0-9]{4}-[0-9]{4}";
            //string padrao = "[0-9]{4,5}-[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";



            string texto = "Meu número é: 2342-3245";

            Match match = Regex.Match(texto, padrao);
            Console.WriteLine(match.Value);

            Console.ReadLine();

            // pagina?argumentos
            // 012345678



            //moedaOrigem=real&moedaDestino=dolar
            //                             |
            //            ----------------´

            string url = "www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);

            extrator.GetValor("moedaOrigem");//real
            extrator.GetValor("moedaDestino");//dolar
            extrator.GetValor("Valor");//1500




            string palavra = "moedaOrigem=moedaDestino&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);

            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));
            Console.ReadLine();





            // Testando o IsNullOrEmpty
            string textoVazio = "";
            string textoNulo = null;
            string textoQualquer = "kjhfsdjhgsdfjksdf";
            Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            Console.WriteLine(String.IsNullOrEmpty(textoQualquer));
            Console.ReadLine();






            //ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("");

            //string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);


            Console.ReadLine();
        }
    }


}
