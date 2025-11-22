using ScreenSound;

internal class Program
{
    private static void Main(string[] args)
    {
        Album albumQueen = new Album();
        albumQueen.Nome = "A Night at the Opera";

        Musica musica = new Musica();
        musica.Nome = "Love of my Life";
        musica.Duracao = 213;
        musica.Genero = new Genero();
        musica.Genero.Nome = "Rock";
        musica.ExibirFichaTecnica();

        Musica musica2 = new Musica();
        musica2.Nome = "Bohemian Rhapsody";
        musica2.Duracao = 354;

        albumQueen.AdicionarMusica(musica);
        albumQueen.AdicionarMusica(musica2);

        albumQueen.ExibirMusicasAlbum();
    }
}