using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            var alunos = new string[5] { "felipe", "pedro", "algusto", "pedro", "lucas" };

            foreach(string aluno in alunos)
            {
                Console.WriteLine(aluno.ToUpper());
            }
        }
        
    }
}
