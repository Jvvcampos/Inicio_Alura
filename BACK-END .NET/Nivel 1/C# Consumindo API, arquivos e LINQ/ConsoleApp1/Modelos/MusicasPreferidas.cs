using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ScreenSound04.Modelos
{
    internal class MusicasPreferidas
    {
        public string? Nome { get; set; }
        public List<Musica> ListaMusica { get; private set; }

        public MusicasPreferidas(string nome) 
        {
            this.Nome = nome;
            ListaMusica = new List<Musica>();
        }

        public void AdicionarMusicasFavoritas(Musica musica)
        {
            ListaMusica.Add(musica);
        }

        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");
            foreach(var musica in ListaMusica)
            {
                Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
            }
            Console.WriteLine();
        }

        public void GerarArquivoJson()
        {
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                musicas = ListaMusica
            });

            string nomeArquivo = $"musicas-favoritas-{Nome}.json";

            File.WriteAllText(nomeArquivo, json);
            Console.WriteLine($"Arquivo json criado! {Path.GetFullPath(nomeArquivo)}");
        }
    }
}
