using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Avançado
{

    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Nota { get; set; }
    }


    class LINQ2
    {

        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno() {Nome = "Pedro", Idade = 24, Nota = 8.0},
                new Aluno() {Nome = "Andre", Idade = 21, Nota = 4.3},
                new Aluno() {Nome = "Ana", Idade = 25, Nota = 9.5},
                new Aluno() {Nome = "Jorge", Idade = 20, Nota = 8.5},
                new Aluno() {Nome = "Ana", Idade = 21, Nota = 7.7},
                new Aluno() {Nome = "Julia", Idade = 22, Nota = 7.5},
                new Aluno() {Nome = "Marcio", Idade = 18, Nota = 6.8},
            };


            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));

            Console.WriteLine($"Nome: {pedro.Nome}\nNota: {pedro.Nota}");


            var fulano = alunos.SingleOrDefault(fulano => fulano.Nome.Equals("julia"));

            Console.WriteLine($"Nome: {fulano.Nome}\nNota: {fulano.Nota}");
        }
    }
}
