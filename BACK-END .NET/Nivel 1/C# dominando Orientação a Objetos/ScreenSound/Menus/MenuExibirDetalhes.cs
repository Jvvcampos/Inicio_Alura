using ScreenSound.Modelos;

namespace ScreenSound.Menus;
internal class MenuExibirDetalhes : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Detalhes da banda");
        Console.Write("Digite o nome da banda que deseja ver os detalhes: ");
        string nomeBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            Banda banda = bandasRegistradas[nomeBanda];
            Console.WriteLine($"A média da nota da banda {nomeBanda} foi de {banda.Media}.");
            Console.WriteLine($"Discografia:");

            foreach (Album album in banda.Albuns)
            {
                Console.WriteLine($"{album.Nome} -> {album.Media}");
            }
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
