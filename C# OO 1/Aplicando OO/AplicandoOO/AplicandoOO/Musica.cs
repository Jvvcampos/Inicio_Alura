using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    class Musica
    {
        public Musica(Banda artista, string nome)
        {
            Artista = artista;
            Nome = nome;
        }
        public string Nome {  get; }
        public Banda Artista {  get; }
        public int Duracao {  get; set; }
        public bool Disponivel { get; set; }

        public Genero? Genero { get; set; }

        public string DescricaoResumida =>
            $"A música {Nome} pertence a banda {Artista.Nome}";

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Duração: {Duracao}");
            Console.WriteLine($"Genero: {Genero?.Nome ?? "Música sem gênero definido!"}");
            if (Disponivel)
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
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista}");
        }
    }
}
