/*
    Seja um arquivo com músicas em formato CSV (Comma Separated Values). 

    Implemente as funções abaixo:
    //     [ X ] Leia-o como uma coleção de músicas
    //     [ X ] Filtre a coleção por artista (por ex. Coldplay, Metallica, AC/DC)
    //     [ X ] Filtre a coleção por gênero (por ex. rock)
    //     [ X ] Filtre a coleção por duração (por ex. maiores que 5 minutos)
    //     [ X ] Ordene a coleção por artista
    //     [ X ] Ordene a coleção por artista e em seguida por músicas com duração crescente
    //     [ X ] Crie uma coleção de artistas e suas músicas
    //     [ X ] Informe a duração média das músicas da coleção
    //     [ X ] Informe a duração total das músicas da coleção
    //     [ X ] Informe qual artista tem mais músicas na coleção
           [ X ] Artistas com pelo menos uma música acima de 8 minutos (480)
           [ X ] Artistas com pelo menos uma música de Reggae
           [ ] Existem músicas de Jazz na coleção?
 
*/
using var arquivo = new FileStream("musicas.csv", FileMode.Open, FileAccess.Read);
using var stream = new StreamReader(arquivo);

OperacoesDeVerificacaoExistencia(stream);

void OperacoesDeVerificacaoExistencia(StreamReader stream)
{
    var musicas = ObterMusicas(stream).ToList();

    var artistas = musicas
        .GroupBy(m => m.Artista)
        .Where(g => g.Any(m => m.Duracao >= 480));

    Console.WriteLine("Artistas com músicas acima de 8 minutos:");
    foreach (var artist in artistas)
    {
        Console.WriteLine($"\t - {artist.Key}");
    }
    var reggae = musicas
    .GroupBy(m => m.Artista)
    .Where(g => g.Any(m => m.Generos.Contains("Reggae")));

    Console.WriteLine("Artistas que tenham alguma música Reggae:");
    foreach (var artist in reggae)
    {
        Console.WriteLine($"\t - {artist.Key}");
    }
}

void ArtistaMaiorQtd(StreamReader stream)
{
    var artistaMaior = ObterMusicas(stream)
    .GroupBy(m => m.Artista)
    .Select(g => new { Artista = g.Key, Musicas = g, Total = g.Count() })
    .MaxBy(a => a.Total);

    if (artistaMaior is not null)
        Console.WriteLine($"O artista com maior quantidade de músicas é {artistaMaior.Artista} com " +
            $"{artistaMaior.Total} músicas!");
}

void OperacoesDeObtencaoDeElementos(StreamReader stream)
{
    var musicas = ObterMusicas(stream).ToList();

    var primeiraMusica = musicas.FirstOrDefault();
    Console.WriteLine($"A primeira música é {primeiraMusica.Titulo}");

    var maiorDuracao = musicas.MaxBy(m => m.Duracao);
    if(maiorDuracao is not null)
        Console.WriteLine($"A música com maior é {maiorDuracao.Titulo} com {maiorDuracao.Duracao} SEGS");
}


void OperacoesDeAgrupamento(StreamReader stream)
{
    var artistas = ObterMusicas(stream)
    .GroupBy(m => m.Artista);

    Console.WriteLine($"\nExibindo as músicas de cada artista:");
    foreach (var artista in artistas.Take(5))
    {
        Console.WriteLine($"Artista: {artista.Key} com {artista.Count()} musicas");
        foreach (var musica in artista)
        {
            Console.WriteLine($"\t - {musica.Titulo}");
        }
    }
}

void EstatisticasDeMusicas(StreamReader stream)
{
    var musicas = ObterMusicas(stream).ToList();

    Console.WriteLine($"\nExistem {musicas.Count()} músicas na coleção.");
    Console.WriteLine($"\nExistem {musicas.Count(m => m.Duracao >= 600)} músicas com mais do que 10 minutos na coleção.");
    Console.WriteLine($"\nA música com menor duração da coleção leva {musicas.Min(m => m.Duracao)} segundos.");
    Console.WriteLine($"\nA música com maior duração da coleção leva {musicas.Max(m => m.Duracao)} segundos.");
    Console.WriteLine($"\nA duração média das músicas da coleção é {musicas.Average(m => m.Duracao)} segundos.");
    Console.WriteLine($"\nVocê vai levar {musicas.Sum(m => m.Duracao)/(3600*24)} dias para ouvir toda a coleção!");
}

void OperacoesDeProjecao2(StreamReader stream)
{
    var generos = ObterMusicas(stream)
        .SelectMany(m => m.Generos) //projeção
        .Distinct()
        .OrderBy(g => g);

    foreach (var genero in generos)
    {
        Console.WriteLine(genero);
    }
}

void OperacoesDeProjecao(StreamReader stream)
{
    var artistas = ObterMusicas(stream)
    .Select(m => m.Artista)//projeção
    .Distinct()//filtragem
    .OrderBy(a => a); //ordenação

    foreach (var artista in artistas)
    {
        Console.WriteLine(artista);
    }
}

void OperacoesDeFiltroEOrdenacao(StreamReader stream)
{
    var musicas =
    ObterMusicas(stream)
    .Where(musica => musica.Artista == "Coldplay")
    .OrderBy(m => m.Titulo)
    .ThenBy(m => m.Duracao)
    .Skip(5 * 2)
    .Take(5);

    ExibirMusicas(musicas);
}

void ExibirMusicas(IEnumerable<Musica> musicas)
{
    var contador = 1;
    Console.WriteLine($"\nExibindo as músicas: ");
    foreach (var musica in musicas)
    {
        Console.WriteLine($"\t - {musica.Titulo} ({musica.Artista} - {musica.Duracao} seg)");
        contador++;
        if (contador > 50) break;
    }
}

IEnumerable<Musica> ObterMusicas(StreamReader reader)
{
    var linha = stream.ReadLine();
    while (linha is not null)
    {
        var leitura = linha.Split(';');
        var musica = new Musica
        {
            Titulo = leitura[0],
            Artista = leitura[1],
            Duracao = Convert.ToInt32(leitura[2]),
            Generos = leitura[3].Split(",").Select(g => g.Trim())
        };
        yield return musica;
        linha = stream.ReadLine();
    }
}

class Musica()
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public IEnumerable<string> Generos { get; set; }
}