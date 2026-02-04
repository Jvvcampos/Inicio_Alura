using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    class Podcast
    {
        public Podcast(string host, string nome)
        {
            this.Host = host;
            this.Nome = nome;
            this.TotalEpisodios = new List<Episodio>();
        }

        public string Host { get; }
        public string Nome { get; }
        List<Episodio> TotalEpisodios { get; }

        public void AdicionarEpisodio(Episodio episodio)
        {
            TotalEpisodios.Add(episodio);
            Console.WriteLine($"O episodio de titulo {episodio.Titulo} foi adicionado!");
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"\nO Podcast {Nome} hospedado por {Host} possui {TotalEpisodios.Count} episódios.");
            Console.WriteLine("\nLista de episódios: ");
            foreach (var ep in TotalEpisodios.OrderBy(e => e.Ordem))
            {
                Console.WriteLine(ep.Resumo);
            }
        }
    }
}
