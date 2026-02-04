using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula1.Filmes;
class Filme
{
    public string Titulo { get; set; }
    public int Duracao { get; set; }
    private readonly List<Artista> _elenco = new List<Artista>();
    public IEnumerable<Artista> Elenco => _elenco;

    public Filme(string titulo, int duracao)
    {
        this.Titulo = titulo;
        this.Duracao = duracao;
    }

    public void AdicionarArtista(Artista artista)
    {
        if (TentarAdicionarArtista(artista))
        {
            Console.WriteLine($"O artista {artista.Nome} foi adicionado com sucesso ao filme {this.Titulo}");

            return;
        }
        else
        {
            Console.WriteLine($"Já existe o artista {artista.Nome} no elenco");
        }
    }

    public bool TentarAdicionarArtista(Artista artista)
    {
        if(artista == null || _elenco.Contains(artista))
        {
            return false;
        }

        _elenco.Add(artista);
        artista.TentarAdicionarFilme(this);

        return true;
    }

}

