using var arquivo = new FileStream("musicas.csv", FileMode.Open, FileAccess.Read);
using var stream = new StreamReader(arquivo);



void AlterandoTitulo(StreamReader stream)
{
    var musica = ObterMusicas(stream)
    .Where(m => m.Titulo.StartsWith('T'))
    .FirstOrDefault();

    if (musica is not null)
    {
        Console.WriteLine($"Titulo da música: {musica.Titulo}");
        musica.Titulo = musica.Titulo.Replace("The ", ""); //imutabilidade
        Console.WriteLine($"Titulo da música: {musica.Titulo}");
    }
}
void ComparandoStrings(StreamReader stream)
{
    var musicas = ObterMusicas(stream)
        .Where(musica => musica.Artista.Equals("COLDPLAY", StringComparison.OrdinalIgnoreCase))
        //.Where(m => m.Artista.ToUpper() == "COLDPLAY")
        .Take(20);

    // métodos que utilizam StringComparison
    "Coldplay".Equals("coldplay", StringComparison.OrdinalIgnoreCase);
    "Coldplay".StartsWith("cold", StringComparison.OrdinalIgnoreCase);
    "Coldplay".EndsWith("coldplay", StringComparison.OrdinalIgnoreCase);
    "Coldplay".IndexOf("coldplay", StringComparison.OrdinalIgnoreCase);
    "Coldplay".Contains("OLD", StringComparison.OrdinalIgnoreCase);
    "Coldplay".Replace("cold", "warm", StringComparison.OrdinalIgnoreCase);

    ExibirMusicasEmTabela(musicas);
}

void usandoSenha()
{
    //var titulo = "Músicas do arquivo";
    //foreach(var c in titulo) Console.WriteLine(c);


    var senha = "Joao123@";
    /*
     * Senha será forte se:
     * 0. Possui pelo menos 8 caracteres
     * 1. Possui alguma letra maiuscula
     * 2. Possui alguma letra minuscula
     * 3. Possui algum numero
     * 4. Possui algum simbolo
     */

    var totalCaracteres = senha.Length;
    var totalLetrasMaiusculas = senha.Count(c => char.IsUpper(c));
    var totalLetrasMinusculas = senha.Count(c => char.IsLower(c));
    var totalNumeros = senha.Count(c => char.IsDigit(c));
    var totalSimbolos = senha.Count(c => !char.IsLetterOrDigit(c));

    if (totalCaracteres < 8 || totalLetrasMaiusculas < 1 || totalLetrasMinusculas < 1
        || totalNumeros < 1 || totalSimbolos < 1)
    {
        Console.WriteLine("A senha é fraca!");
    }
    else
    {
        Console.WriteLine("A senha digitada é forte");
    }
}

void ExibirMusicas(IEnumerable<Musica> musicas)
{
    Console.WriteLine($"\nExibindo as músicas: ");
    foreach (var musica in musicas)
    {
        var linha = $"\t - {musica.Titulo} ({musica.Artista} - {musica.Duracao} seg -" +
            $"[{musica.Lancamento}])";
        Console.WriteLine(linha);
    }
}

void ExibirMusicasEmTabela(IEnumerable<Musica> musicas)
{
    var titulo = "\nMúsicas do arquivo: ";

    var colunaTitulo = "Titulo".PadRight(40);
    var colunaArtista = "Artista".PadRight(30);
    var colunaDuracao = "Duração".PadRight(10);
    var colunaLancamento = "Lançada Em".PadRight(15);
    Console.WriteLine($"{colunaTitulo}{colunaArtista}{colunaDuracao}{colunaLancamento}");
    var borda = "".PadRight(100, '-');
    Console.WriteLine(borda);

    foreach (var musica in musicas)
    {
        var duracao = string.Format("{0,-10:F2}", musica.Duracao/60.0);
        var linha = $"{musica.Titulo,-40}{musica.Artista,-30}{duracao}" +
            $"{musica.Lancamento,-15:dd/MM/yyyy}";
        Console.WriteLine(linha);
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
            Generos = leitura[3].Split(',', StringSplitOptions.TrimEntries),
            Lancamento = Convert.ToDateTime(leitura[4])
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
    public DateTime Lancamento { get; set; }

    public override string ToString()
    {
        return $"{Titulo} ({Artista} - {Duracao} seg - [{Lancamento}])";
    }
}