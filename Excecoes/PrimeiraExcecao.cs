using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    class Conta
    {
        double saldo;

        public Conta(double saldo)
        {
            this.saldo = saldo;
        }

        public void Sacar(double valor)
        {
            if(valor > saldo)
            {
                throw new ArgumentException("Saldo Insuficiente");
            }

            saldo -= valor;
        }
    }
    class PrimeiraExcecao
    {
        internal static void Executar()
        {
            Conta c = new Conta(1);

            try
            {
                c.Sacar(10);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
