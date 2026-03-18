using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula3
{
    class Titular
    {
        public Titular(string nome, string cpf, string endereco) 
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Endereco = endereco;
        }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
    }
}
