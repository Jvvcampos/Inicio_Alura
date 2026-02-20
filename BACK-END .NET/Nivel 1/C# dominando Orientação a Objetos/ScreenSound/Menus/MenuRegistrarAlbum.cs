using ScreenSound.Modelos;

namespace ScreenSound.Menus;
internal class MenuRegistrarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro de álbuns");
        Console.Write("Digite a banda cujo álbum deseja registrar: ");
        string nomeBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            Album album = new Album(tituloAlbum);
            Banda banda = bandasRegistradas[nomeBanda];
            banda.AdicionarAlbum(album);
            Console.WriteLine($"O álbum {tituloAlbum} de {nomeBanda} foi registrado com sucesso!");
            Thread.Sleep(4000);
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
