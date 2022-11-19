using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    class Heranca
    {

        public class Carro
        {
            protected readonly int VelocidadeMaxima;
            int VelocidadeAtual;


            public Carro(int velocidadeMaxima)
            {
                VelocidadeMaxima = velocidadeMaxima;
            }

            protected int AlterarVelocidade(int delta)
            {
                int novaVelocidade = VelocidadeAtual + delta;

                if (novaVelocidade < 0)
                {
                    VelocidadeAtual = 0;
                }
                else if (novaVelocidade > VelocidadeMaxima)
                {
                    VelocidadeAtual = VelocidadeMaxima;
                }
                else
                {
                    VelocidadeAtual = novaVelocidade;
                }

                return VelocidadeAtual;
            }

           
        }
        public static void Executar()
        {

        }
    }
}
