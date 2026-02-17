using ScreenSound.Modelos;

namespace ScreenSound.Menus;
internal class MenuExibirDetalhes : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Média da nota de uma banda");
        Console.Write("Digite o nome da banda que deseja ver a média: ");
        string nomeBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            Banda banda = bandasRegistradas[nomeBanda];
            Console.WriteLine($"A média da banda {nomeBanda} foi de {banda.Media}.");
        }
        else
        {
            Console.WriteLine("\nEssa banda ainda não foi registrada!");
            Console.WriteLine("Digite alguma tecla para voltar");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
