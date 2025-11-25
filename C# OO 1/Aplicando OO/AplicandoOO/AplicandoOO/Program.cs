using ScreenSound;

internal class Program
{
    private static void Main(string[] args)
    {

        Banda queen = new Banda("Queen");
        Album albumQueen = new Album("A Night at the Opera");

        Musica musica = new Musica(queen, "Love of my Life")
        {
            Duracao = 213,
            Disponivel = true,
            Genero = new Genero { Nome = "Rock"}
        };
        musica.ExibirFichaTecnica();

        Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
        {
            Duracao = 354,
            Disponivel = false,
        };
        musica2.ExibirFichaTecnica();

        albumQueen.AdicionarMusica(musica);
        albumQueen.AdicionarMusica(musica2);
        albumQueen.ExibirMusicasAlbum();

        queen.AdicionarAlbum(albumQueen);
        queen.ExibirDiscografia();
    }
}   