using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContatos.Modelos
{
    internal class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Contato(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }
    }
}
