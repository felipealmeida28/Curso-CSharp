using CursoCSharp.Fundamentos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.Metodos;
using CursoCSharp.Excecoes;
using CursoCSharp.API;
using CursoCSharp.Avançado;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar },
                {"Desafio", Desafio.Executar },
                {"Params", Params.Executar },
                {"Parametros nomeados", ParametrosNomeados.Executar },
                {"Get Set", GetSet.Executar },
                {"Props", Props.Executar },
                {"ReadOnly", Readonly.Executar },
                {"Struct", Struct.Executar },
                //coleções
                {"Arrays", Colecoes.Array.Executar},
                {"Listas", Lists.Executar},
                {"Queue", Queue.Executar},
                {"Igualdade", Igualdade.Executar},
                {"Stack", StackC.Executar},
                {"Dictionary", DictionaryC.Executar},
                {"Heranca", Heranca.Executar},
                {"Abstract", Abstract.Executar},
                {"Lambdas", Lambdas.Executar},
                {"LambdasDelegate", LambdasDelegate.Executar},
                {"UsandoDelegates", UsandoDelegates.Executar},
                {"DelegatesFunAnonimas", DelegatesFunAnonimas.Executar},
                {"DelegatesComoParametros", DelegatesComoParametros.Executar},
                {"MetodosDeExtensao", MetodosDeExtensao.Executar},
                {"PrimeiraExcecao", PrimeiraExcecao.Executar},
                {"ExcecoePersonalizadas", ExcecoePersonalizadas.Executar},
                {"PrimeiroArquivo", PrimeiroArquivo.Executar},
                {"LendoArquivos", LendoArquivos.Executar},
                {"FileInfo", API.ExFileInfo.Executar},
                {"ExDateTime", API.ExDateTime.Executar},
                {"ExTimeSpan", API.ExTimeSpan.Executar},
                {"LINQ1", LINQ1.Executar},
                {"LINQ2", LINQ2.Executar},
                {"Nullables", Nullables.Executar},
                {"Genericos", Genericos.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}