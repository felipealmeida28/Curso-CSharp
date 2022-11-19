using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.API
{
    class ExFileInfo
    {
        public static void ExcluirSeExistir(params string[] caminhos)
        {
            foreach(var caminho in caminhos)
            {
                FileInfo arquivo = new FileInfo(caminho);

                if (arquivo.Exists) 
                {
                    arquivo.Delete();
                }
            }
        }

        public static void Executar()
        {
            var caminho = @"~/arq_origem.txt".ParseHome();
            var destino = @"~/arq_destino.txt".ParseHome();
            var copia = @"~/arq_copia.txt".ParseHome();

            ExcluirSeExistir(caminho, destino, copia);


            using (StreamWriter sw = File.CreateText(caminho))
            {
                sw.WriteLine("Arquivo Original");
            }

            FileInfo origem = new FileInfo(caminho);
            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.IsReadOnly);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.Extension);

            origem.CopyTo(copia);
            origem.MoveTo(destino);
        }
    }
}
