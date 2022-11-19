using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual Seu Nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o seu salario?");

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine($"Nome: {nome}\n Idade: {idade}\n Salario: {salario}");
        }
    }
}
