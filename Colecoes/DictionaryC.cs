using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
     class DictionaryC
    {
        //Dicionario tem o papel de criar uma coleção com chaves únicas 
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Spider-Man");
            filmes.Add(2004, "Os Incriveis");
            filmes.Add(2006, "Super Man");

            if (filmes.ContainsKey(2000))
            {
                Console.WriteLine("2000: " + filmes[2000]);
                Console.WriteLine("2000: " + filmes.GetValueOrDefault(2000));
                filmes.TryGetValue(2010, out string filme2000);
                Console.WriteLine(filme2000);
            }
        }
    }
}
