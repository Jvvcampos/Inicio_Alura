using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuAvaliarAlbum : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Avaliar álbum");
            Console.Write("Digite o nome da banda à ser avaliada: ");
            string nomeBanda = Console.ReadLine()!;

            if (bandasRegistradas.ContainsKey(nomeBanda))
            {
                Banda banda = bandasRegistradas[nomeBanda];
                Console.Write("Agora digite o título do álbum: ");
                string tituloAlbum = Console.ReadLine()!;

                if(banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
                {
                    Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                    Console.Write($"Digite a nota que o album {tituloAlbum} merece: ");
                    Avaliacao nota = Avaliacao.Parse(Console.ReadLine());
                    album.AdicionarNota(nota);
                    Console.WriteLine($"A nota {nota.Nota} foi registrada para o álbum {tituloAlbum}.");
                    Console.WriteLine("Digite alguma tecla para voltar");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"O álbum {tituloAlbum} da {nomeBanda} não foi encontrado!");
                    Console.WriteLine("Digite alguma tecla para voltar ao menu!");
                    Console.ReadKey();
                    Console.Clear();
                }
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
}
