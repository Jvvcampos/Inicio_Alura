using ScreenSound04.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound04.Filtros
{
    internal class LinqFilter
    {
        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {
            var todosOsGenerosMusicais = musicas.Select(musica => musica.Genero).Distinct().ToList();
            foreach (var genero in todosOsGenerosMusicais)
            {
                Console.WriteLine($"- {genero}");
            }
        }

        public static void FiltrarArtistasPorGenero(List<Musica> musicas, string genero)
        {
            var ArtistasPorGenero = musicas.Where(musica => musica.Genero.Contains(genero))
                .Select(musica => musica.Artista).Distinct().ToList();
            Console.WriteLine($"Listas de artistas do gênero: {genero}");

            foreach(var artista in ArtistasPorGenero)
            {
                Console.WriteLine($"- {artista}");
            }
        }

        public static void FiltrarMusicasArtista(List<Musica> musicas, string artista)
        {
            var MusicasPorArtista = musicas.Where(musica => musica.Artista!.Equals(artista))
                .Select(musica => musica.Nome).Distinct().ToList();
            Console.WriteLine($"Lista de músicas do artista: {artista}");

            foreach(var musica in MusicasPorArtista)
            {
                Console.WriteLine($"- {musica}");
            }

        }

        public static void FiltrarMusicasAno(List<Musica> musicas, string ano)
        {
            var MusicasPorAno = musicas.Where(musica => musica.Ano.Equals(ano)).
                Select(musica => musica.Nome).Distinct().ToList();
            Console.WriteLine($"Lista de músicas lançadas no ano: {ano}");

            foreach(var musica in MusicasPorAno)
            {
                Console.WriteLine($"- {musica}");
            }
        }
    }
}