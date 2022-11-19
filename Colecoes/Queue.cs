using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class Queue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("fulano");
            fila.Enqueue("sicrano");
            fila.Enqueue("beltrano");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count());
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count());

            // para criar filas com tipos genericos
            var salada = new Queue();
            
        }
    }
}
