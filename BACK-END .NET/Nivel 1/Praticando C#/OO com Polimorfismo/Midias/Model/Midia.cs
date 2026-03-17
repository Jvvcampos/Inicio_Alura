using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midias.Model
{
    internal class Midia
    {
        public string Nome { get; set; }

        internal Midia(string nome)
        {
            this.Nome = nome;
        }

        internal virtual void ExibirDetalhes()
        {
            Console.WriteLine($"Arquivo: {Nome}");
        }
    }
}
