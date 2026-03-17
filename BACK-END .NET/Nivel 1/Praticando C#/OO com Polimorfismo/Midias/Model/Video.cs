using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midias.Model
{
    internal class Video : Midia
    {
        public double Duracao { get; set; }

        public Video(string nome, double duracao) : base(nome)
        {
            this.Duracao = duracao;
        }

        internal override void ExibirDetalhes()
        {
            Console.WriteLine($"Video: {Nome} - Duração: {Duracao} minutos");
        }
    }
}
