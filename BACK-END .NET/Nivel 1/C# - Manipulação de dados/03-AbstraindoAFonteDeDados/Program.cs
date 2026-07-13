/*
    Seja um arquivo com músicas em formato CSV (Comma Separated Values). 

    Implemente as funções abaixo:
    //     [ X ] Leia-o como uma coleção de músicas
    //     [ X ] Filtre a coleção por artista (por ex. Coldplay, Metallica, AC/DC)
    //     [  ] Filtre a coleção por gênero (por ex. rock)
    //     [ ] Filtre a coleção por duração (por ex. maiores que 5 minutos)
    //     [ ] Ordene a coleção por artista
    //     [ ] Ordene a coleção por artista e em seguida por músicas com duração crescente
    //     [ ] Crie uma coleção de artistas e suas músicas
    //     [ ] Informe a duração média das músicas da coleção
    //     [ ] Informe a duração total das músicas da coleção
    //     [ ] Informe qual artista tem mais músicas na coleção
 
*/
using var arquivo = new FileStream("musicas.csv", FileMode.Open, FileAccess.Read);
using var stream = new StreamReader(arquivo);

var musicas =
    ObterMusicas(stream)
    .Where(musica => musica.Artista == "Coldplay")
    .Where(musica => musica.Titulo.StartsWith('C'))
    .Where(FiltrarMaisLongas);

ExibirMusicas(musicas);

void ExibirMusicas(IEnumerable<Musica> musicas)
{
    var contador = 1;
    Console.WriteLine($"\nExibindo as músicas: ");
    foreach(var musica in musicas)
    {
        Console.WriteLine($"\t - {musica.Titulo} ({musica.Artista} - {musica.Duracao} seg)");
        contador++;
        if (contador > 50) break;
    }
}

IEnumerable<Musica> ObterMusicas(StreamReader reader)
{
    var linha = stream.ReadLine();
    while(linha is not null)
    {
        var leitura = linha.Split(';');
        var musica = new Musica
        {
            Titulo = leitura[0],
            Artista = leitura[1],
            Duracao = Convert.ToInt32(leitura[2])
        };
        foreach (var leia in leitura)
        {
            if (leia.Contains(','))
            {
                var generos = leia.Split(',');
                musica.Genero = generos[0];
                musica.Genero2 = generos[1].TrimStart();
            }
        }
        yield return musica;
        linha = stream.ReadLine();
    }
}

bool FiltrarPorArtista(Musica musica) => musica.Artista == "Coldplay";
bool FiltrarMaisLongas(Musica m) => m.Duracao >= 300;
bool FiltrarPorTituloComecaComA(Musica musica) => musica.Titulo.StartsWith('A');

static class MusicasExtensions
{
    public static IEnumerable<Musica> FiltrarPorGenero(this IEnumerable<Musica> musicas,string genero)
    {
        foreach (var musica in musicas)
        {
            if (musica.Genero == genero || musica.Genero2 == genero) yield return musica;
        }
    }

    public static IEnumerable<T> FiltrarPor<T>(this IEnumerable<T> musicas, Func<T, bool> condicao)
    {
        foreach (var musica in musicas)
        {
            if (condicao(musica)) yield return musica;
        }
    }
}

class Musica()
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public string Genero {  get; set; }
    public string Genero2 { get; set; }
}