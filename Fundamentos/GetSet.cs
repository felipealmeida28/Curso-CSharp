using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class GetSet
    {
        public class Moto
        {
            private string Marca;
            private string Modelo;
            private int Cilindrada;

            public Moto(string marca, string modelo, int cilindrada)
            {
                Marca = marca;
                Modelo = modelo;
                Cilindrada = cilindrada;
            }


            public Moto() 
            { 

            }

            public string GetMarca()
            {
                return Marca;
            }

            public void SetMarca(string marca)
            {
                Marca = marca;
            }
        }

        public static void Executar()
        {

        }
    }
}
