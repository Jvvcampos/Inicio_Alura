using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    class Musica
    {
        public string nome;
        public string artista;
        public double duracao;
        private bool disponivel;

        public void EscreveDisponivel(bool value)
        {
            disponivel = value;
        }

        public bool LerDisponivel()
        {
            return disponivel;
        }

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Artista: {artista}");
            Console.WriteLine($"Duração: {duracao}");
            if (disponivel)
            {
                Console.WriteLine("Disponível no plano.");
            }
            else
            {
                Console.WriteLine("Adquira o plano plus+");
            }
        }

        public void ExibirNome()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Artista: {artista}");
        }
    }
}
