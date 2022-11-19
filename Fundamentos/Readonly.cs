using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }


        public string GetDataDeNascimento()
        {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }

    }

    class Readonly
    {
        public static void Executar()
        {
            Cliente cliente = new Cliente(nome: "felipe",nascimento: new DateTime(1987, 5, 22));

            Console.WriteLine(cliente.Nome);
            Console.WriteLine(cliente.GetDataDeNascimento());
        }
    }
}
