using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Modelos;
internal class Episodio
{
    public Episodio(int duracao, int ordem, string titulo)
    {
        this.Duracao = duracao;
        this.Ordem = ordem;
        this.Titulo = titulo;
        Convidados = new List<string>();
    }

    public int Duracao { get; }
    public int Ordem { get; }
    public string Resumo =>
        $"Episódio: {Ordem}# - {Titulo} com {Duracao} min. Convidados: {string.Join(", ", Convidados)}";
    public string Titulo { get; }
    List<string> Convidados { get; }

    public void AdicionarConvidados(string nome)
    {
        Convidados.Add(nome);
        Console.WriteLine($"O convidado {nome} foi adicionado!");
    }
}

