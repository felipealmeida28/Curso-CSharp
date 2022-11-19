using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Struct
    {
        interface Ponto
        {
            void MoverDiagonal(int delta);
        }

        struct Coordenada : Ponto
        {
            public int X;
            public int Y;

            public Coordenada(int x, int y)
            {
                X = x;
                Y = y;
            }


            public void MoverDiagonal(int delta)
            {
                X += delta;
                Y += delta;
            }
        }


        public static void Executar()
        {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine("Coordenada Inicial: ");
            Console.WriteLine("X = {0}", coordenadaInicial.X);
            Console.WriteLine("X = {0}", coordenadaInicial.Y);


            var coordenadaFinal = new Coordenada(9, 1);

            coordenadaFinal.MoverDiagonal(10);

            Console.WriteLine("X = {0}", coordenadaFinal.X);
            Console.WriteLine("X = {0}", coordenadaFinal.Y);

        }

    }
}
