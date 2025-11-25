using DesafioAula3;

class Program
{
    private static void Main(string[] args)
    {
        Titular titular = new Titular("Joao", "1234", "rua 1");
        Conta conta = new Conta(titular, 30, 520, 1000, 200);

        Console.WriteLine(conta.Informacoes);

        Jogo jogo = new Jogo("GTA5", "Ação", 2013);
        CatalogoJogos catalogo = new CatalogoJogos();
        catalogo.AdicionarJogo(jogo);
        catalogo.AdicionarJogo("GTA6", "Ação", 2026);
        catalogo.ListarJogos();
    }
}