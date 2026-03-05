using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamento.Modelos
{
    internal abstract class Pessoa
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }

        protected Pessoa(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }
    }
}
