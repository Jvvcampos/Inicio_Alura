using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula1.Filmes;
class Artista
{
    private readonly List<Filme> _filmes = new List<Filme>();

    public Artista(string nome, int idade)
    {
        this.Nome = nome;
        this.Idade = idade;
    }

    public string Nome { get; set; }
    public int Idade { get; set; }

    public IEnumerable<Filme> Filmes => _filmes;

    public void AdicionarFilme(Filme filme)
    {
        if (TentarAdicionarFilme(filme))
        {
            Console.WriteLine($"O filme {filme.Titulo} foi adicionado com sucesso ao artista {this.Nome}");

            return;
        }
        else
        {
            Console.WriteLine($"Já existe o filme {filme.Titulo} na lista do artista");
        }
    }

    public bool TentarAdicionarFilme(Filme filme)
    {
        if (filme == null || _filmes.Contains(filme))
        {
            return false;
        }

        _filmes.Add(filme);
        filme.TentarAdicionarArtista(this);

        return true;
    }
}
