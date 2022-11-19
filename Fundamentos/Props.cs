using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{

    class CarroOpcional
    {
        double desconto = 0.1;

        private string _nome;
        public string Nome 
        {
            get => _nome; 
            set 
            {
                _nome = value;
            } 
        }

      public  CarroOpcional(string nome)
        {   
            Nome = nome;

            Console.WriteLine(_nome);
        }
    }
    class Props
    {
        
        public static void Executar()
        {
            var nome1 = new CarroOpcional("felipe almeida");
        }
    }
}
