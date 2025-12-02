using ScreenSound.Modelos;

namespace ScreenSound.Menus;
internal class MenuAvaliarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliar bandas");
        Console.Write("Digite o nome da banda à ser avaliada: ");
        string nomeBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            Banda banda = bandasRegistradas[nomeBanda];
            Console.Write($"Digite a nota que a banda {nomeBanda} merece: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine());
            banda.AdicionarNota(nota);
            Console.WriteLine($"A nota {nota.Nota} foi registrada para a banda {nomeBanda}.");
            Console.WriteLine("Digite alguma tecla para voltar");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"O nome da {nomeBanda} não foi encontrado!");
            Console.WriteLine("Digite alguma tecla para voltar ao menu!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

