using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Modelos;
internal class Banda : IAvaliavel
{
    private List<Album> _albuns = new List<Album>();
    public IEnumerable<Album> Albuns => _albuns;

    private List<Avaliacao> Notas = new List<Avaliacao>();
    public string? Resumo { get; set; }

    public Banda(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public double Media
    {
        get
        {
            if (Notas.Count == 0) return 0;
            else return Notas.Average(a => a.Nota);
        }
    }

    public void AdicionarAlbum(Album album)
    {
        _albuns.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        Notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");

        foreach (Album album in _albuns)
        {
            Console.WriteLine($"Album: {album.Nome} ({album.DuracaoTotal} segundos)");
        }
    }
}
