using ScreenSound.Modelos;
using System.Threading.Tasks;
using Google.GenAI;
using Google.GenAI.Types;

namespace ScreenSound.Menus;
    internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro de bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);
        var client = new Client(apiKey: "GEMINI_API_KEY");

        var response = client.Models.GenerateContentAsync(
            model: "gemini-3-flash-preview", contents: $"Resuma a banda {nomeDaBanda} em 1 parágrafo. De maneira informal").
            GetAwaiter().GetResult();

        banda.Resumo = response.Candidates[0].Content.Parts[0].Text;

        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Console.WriteLine("Digite alguma tecla para voltar");
        Console.ReadKey();
        Console.Clear();
    }
}

