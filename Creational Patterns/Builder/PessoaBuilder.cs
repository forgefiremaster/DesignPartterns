using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParternExamples.Creational_Patterns.Builder
{
    public class PessoaBuilder
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
        public String Email { get; set; }

        public PessoaBuilder id(int Id)
        {
            this.Id = Id;
            return this;
        }

        public PessoaBuilder nome(String Nome)
        {
            this.Nome = Nome;
            return this;
        }

        public PessoaBuilder sobrenome(String Sobrenome)
        {
            this.Sobrenome = Sobrenome;
            return this;
        }

        public PessoaBuilder email(String Email)
        {
            this.Email = Email;
            return this;
        }

        public Pessoa criarPessoa()
        {
            var pessoa = new Pessoa();
            pessoa.Id = this.Id;
            pessoa.Nome = this.Nome;
            pessoa.Sobrenome = this.Sobrenome;
            pessoa.Email = this.Email;
            return pessoa;
        }
    }
}
