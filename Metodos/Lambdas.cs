using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Metodos
{
    class Lambdas
    {
        public static void Executar()
        {

            // sempre retorna void
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda com c#");
            };

            algoNoConsole();


            Func<int> jogarDado = () =>
            {
                Random radom = new Random();
                return radom.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            //retorna o retorno estabelecido 
            Func<int, string> conversorHex = (numero) =>
            {
                return numero.ToString("X");
            };

            Console.WriteLine(conversorHex(1234));


            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
            {
                return String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            };

            Console.WriteLine(formatarData(10, 11, 2023));
        }
    }
}
