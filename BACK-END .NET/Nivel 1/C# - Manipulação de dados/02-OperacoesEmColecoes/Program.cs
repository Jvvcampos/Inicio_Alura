/*
Seja um aplicativo de gerenciamento de músicas onde os usuários podem organizar suas faixas
favoritas em playlists personalizadas. Para cada playlist, é essencial que o usuário tenha
controle total sobre a sequência de reprodução das músicas, permitindo reordená-las
livremente a qualquer momento. Além disso, o aplicativo precisa oferecer a funcionalidade de
reprodução aleatória para uma playlist específica, proporcionando uma experiência de audição
dinâmica e variada, sem, contudo, alterar a ordem original que o usuário definiu. O desafio
é criar uma estrutura robusta que suporte a adição e remoção eficiente de músicas, a
reordenação flexível dentro das playlists e a seleção de faixas tanto em modo sequencial
quanto aleatório.


Funcoes que vamos implementar:
// [ X ] Criar as classes para musicas e playlist
// [ X ] Listar musicas da playlist
// [ X ] Adicionar musica à playlist
// [ X ] Obter uma musica especifica da playlist
// [ X ] Remover musica da playlist
// [ X ] Tocar uma musica aleatoria da playlist
// [ X ] Reordenar musicas segundo alguma logica especifica (ex. duracao)
// [ X ] Uma playlist nao pode ter musicas repetidas
// [ X ] Exibir as 10 musicas mais tocadas em todas as playlists (ranking)
// [ X ] Player de musica com:
// [ X ] - Fila de reproducao (para musicas avulsas e/ou playlists)
// [ X ] - Historico de reproducao
*/

using System.Collections;

var musica1 = new Musica { Titulo = "Que Pais é Esse?", Artista = "Legião Urbana", Duracao = 350 };
var musica2 = new Musica { Titulo = "Tempo Perdido", Artista = "Legião Urbana", Duracao = 455 };
var musica3 = new Musica { Titulo = "Pro Dia Nascer Feliz", Artista = "Barão Vermelho", Duracao = 375 };
var musica4 = new Musica { Titulo = "Eduardo e Mônica", Artista = "Legião Urbana", Duracao = 530 };
var musica5 = new Musica { Titulo = "Geração Coca-Cola", Artista = "Legião Urbana", Duracao = 350 };

var rockNacional = new Playlist { Nome = "Rock Nacional" };

rockNacional.Add(musica2);
rockNacional.Add(musica1);
rockNacional.Add(musica3);
rockNacional.Add(musica4);
rockNacional.Add(musica5);
rockNacional.Add(new Musica { Titulo = "Eduardo e Mônica", Artista = "Legião Urbana", Duracao = 530 });

ExibirPlaylist(rockNacional);

var legiaoUrbana = new Playlist() { Nome = "Mais populares da Legião" };
legiaoUrbana.Add(musica1);
legiaoUrbana.Add(musica2);
legiaoUrbana.Add(musica4);
legiaoUrbana.Add(musica5);

ExibirPlaylist(legiaoUrbana);
ExibirMaisTocadas(rockNacional, legiaoUrbana);

var player = new PlayerDeMusica();
player.AdicionarNaFila(musica1);
player.AdicionarNaFila(legiaoUrbana);
ExibirFila(player);
ExibirHistorico(player);

var proxima = player.ProximaMusicaFila();
if (proxima is not null)
    Console.WriteLine($"\nTOCANDOO A PROXIMA {proxima.Titulo}...");
else Console.WriteLine("\nFila de reprodução vazia!");

ExibirFila(player);
ExibirHistorico(player);

var anterior = player.MusicaAnterior();
if (anterior is not null)
    Console.WriteLine($"\nTOCANDO A {anterior.Titulo}...");
else Console.WriteLine("\nHistórico de reprodução vazia!");

void ExibirHistorico(PlayerDeMusica player)
{
    Console.WriteLine("\nExibindo o histórico: ");
    foreach(var musica in player.Historico())
    {
        Console.WriteLine($"\t - {musica.Titulo}");
    }
}

ExibirFila(player);
ExibirHistorico(player);

void ExibirFila(PlayerDeMusica player)
{
    Console.WriteLine($"\n Exibindo a fila de produção.");
    foreach (var musica in player.Fila())
    {
        Console.WriteLine($"\t - {musica.Titulo}");
    }
}

void ExibirMaisTocadas(Playlist playlist1, Playlist playlist2)
{
    Dictionary<Musica, int> ranking = [];

    foreach (var musica in playlist1)
    {
        ranking.Add(musica, 1);
    }

    foreach (var musica in playlist2)
    {
        if (ranking.TryGetValue(musica, out int contagem))
        {
            contagem++;
            ranking[musica] = contagem;
        }
        else
        {
            ranking.Add(musica, 1);
        }
    }

    List<KeyValuePair<Musica, int>> top = new(ranking);
    top.Sort(new PorContagem());

    Console.WriteLine("\nTop 3 Músicas mais incluídas nas playlists");
    int contador = 1;
    foreach (var par in top)
    {
        Console.WriteLine($"\t - {par.Key.Titulo}");
        contador++;
        if (contador > 3) break;
    }
}
void ExibirPlaylist(Playlist playlist)
{
    Console.WriteLine($"\n Tocando as musicas de {playlist.Nome}");
    foreach (var musica in playlist)
    {
        Console.WriteLine($"\t - {musica.Titulo} - {musica.Artista} - {musica.Duracao} segundos");
    }
}

void RemoverMusicaPeloTitulo(Playlist playlist, string titulo)
{
    var musicaEncontrada = playlist.ObterPeloTitulo("Eduardo e Mônica");
    if (musicaEncontrada is not null)
    {
        Console.WriteLine("\nRemovendo música...");
        playlist.Remove(musicaEncontrada);
    }
    else
    {
        Console.WriteLine("\nMúsica não encontrada!");
    }

    ExibirPlaylist(playlist);
}

void ExibirMusicaAleatoria(Playlist playlist)
{
    var musicaAleatoria = playlist.ObterAleatoria();
    if (musicaAleatoria is not null)
    {
        Console.WriteLine($"\nA música aleatória é {musicaAleatoria.Titulo}");
    }
    else
    {
        Console.WriteLine("Playlist vazia!");
    }
}

class PorContagem : IComparer<KeyValuePair<Musica, int>>
{
    public int Compare(KeyValuePair<Musica, int> x, KeyValuePair<Musica, int> y)
    {
        return y.Value.CompareTo(x.Value);
    }
}

class PorArtista : IComparer<Musica>
{
    public int Compare(Musica? x, Musica? y)
    {
        if (x is null || y is null) return 0;
        if (x is null) return 1;
        if (y is null) return -1;
        return x.Artista.CompareTo(y.Artista);
    }
}
class PorTitulo : IComparer<Musica>
{
    public int Compare(Musica? x, Musica? y)
    {
        if (x is null || y is null) return 0;
        if (x is null) return 1;
        if (y is null) return -1;
        return x.Titulo.CompareTo(y.Titulo);
    }
}

class Musica : IComparable
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }

    public int CompareTo(object? other)
    {
        if (other is null) return -1;
        if (other is Musica outraMusica) return this.Duracao.CompareTo(outraMusica.Duracao);
        return -1;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (obj is Musica outraMusica)
            return this.Titulo.Equals(outraMusica.Titulo) && this.Artista.Equals(outraMusica.Artista);
        return false;
    }
    public override int GetHashCode()
    {
        return this.Titulo.GetHashCode() ^ this.Artista.GetHashCode();
    }
}

class Playlist : ICollection<Musica>
{
    private HashSet<Musica> set = [];
    public string Nome { get; set; }
    private List<Musica> Lista = new List<Musica>();

    public int Count => Lista.Count;
    public bool IsReadOnly => false;

    public void Add(Musica musica)
    {
        if (set.Add(musica))
        {
            Lista.Add(musica);
        }
    }

    public void Clear()
    {
        Lista.Clear();
    }

    public bool Contains(Musica musica)
    {
        return Lista.Contains(musica);
    }

    public void CopyTo(Musica[] array, int arrayIndex)
    {
        Lista.CopyTo(array, arrayIndex);
    }

    public bool Remove(Musica musica)
    {
        return Lista.Remove(musica);
    }
    public Musica? ObterPeloTitulo(string titulo)
    {
        foreach (var musica in Lista)
        {
            if (musica.Titulo == titulo)
            {
                return musica;
            }
        }
        return null;
    }
    public Musica? ObterAleatoria()
    {
        if (Lista.Count == 0) return null;

        var random = new Random();
        var indiceAleatorio = random.Next(0, Lista.Count - 1);
        return Lista[indiceAleatorio];
    }
    public void OrdenarPorDuracao()
    {
        Lista.Sort();
    }
    public void OrdenarPorArtista()
    {
        Lista.Sort(new PorArtista());
    }
    public void OrdenarPorTitulo()
    {
        Lista.Sort(new PorTitulo());
    }
    public IEnumerator<Musica> GetEnumerator()
    {
        return Lista.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class PlayerDeMusica
{
    private Queue<Musica> fila = []; //(FIFO)
    private Stack<Musica> historico = []; //(LIFO)

    public void AdicionarNaFila(Musica musica)
    {
        fila.Enqueue(musica);
    }

    public void AdicionarNaFila(Playlist playlist)
    {
        foreach (var musica in playlist)
        {
            AdicionarNaFila(musica);
        }
    }

    public Musica? ProximaMusicaFila()
    {
        if (fila.Count == 0) return null;
        var musica = fila.Dequeue();
        historico.Push(musica);
        return musica;
    }

    public Musica? MusicaAnterior()
    {
        if(historico.Count == 0) return null;
        return historico.Pop();
    }

    public IEnumerable<Musica> Fila()
    {
        foreach (var musica in fila)
        {
            yield return musica;
        }
    }

    public IEnumerable<Musica> Historico()
    {
        foreach (var musica in historico)
        {
            yield return musica;
        }
    }
}