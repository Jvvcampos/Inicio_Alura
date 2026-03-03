using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesVip.Modelos
{
    internal abstract class Pessoa
    {
        public string  Nome { get; private set; }
        public int Idade { get; private set; }

        protected Pessoa(string nome, int idade)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new ArgumentException("O nome do produto não pode ser vazio!");
            }
            if (idade <= 10)
            {
                throw new ArgumentException("A idade deve ser superior a 10 anos!");
            }
            this.Idade = idade;
            this.Nome = nome;
        }
    }
}
