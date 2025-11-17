using ScreenSound;

internal class Program
{
    private static void Main(string[] args)
    {
        Musica musica1 = new Musica();
        musica1.nome = "Roxane";
        musica1.artista = "The Police";
        musica1.duracao = 100;
        musica1.disponivel = true;

        Musica musica2 = new Musica();
        musica2.nome = "Vertigo";
        musica2.artista = "U2";
        musica2.duracao = 150;
        musica2.disponivel = false;

        musica1.ExibirFichaTecnica();
        musica2.ExibirFichaTecnica();   
    }
}