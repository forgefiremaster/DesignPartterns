using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParternExamples.Creational_Patterns.Builder
{
    public class BuilderTest
    {
        static void Main(string[] args)
        {
            var pessoa = new PessoaBuilder().id(1).nome("Lucas").sobrenome("Fernandes").email("lucas@fernandes").criarPessoa();
        }
    }
}
