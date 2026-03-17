using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midias.Model
{
    internal class Imagem : Midia
    {
        public string Resolucao { get; set; }

        public Imagem(string nome, string resolucao) : base(nome)
        {
                this.Resolucao = resolucao;
        }

        internal override void ExibirDetalhes()
        {
            Console.WriteLine($"Imagem: {Nome} - Resolução: {Resolucao}");
        }
    }
}
