using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.API
{
    class ExDateTime
    {
       public  static void Executar()
        {
            var dateTime = new DateTime(2022, 11, 18);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            //sem horas


            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            var now = DateTime.Now;
            Console.WriteLine(now);
        }
    }
}
