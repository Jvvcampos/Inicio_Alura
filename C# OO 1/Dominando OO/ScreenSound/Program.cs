using ScreenSound.Modelos;

Banda ira = new Banda("Ira!");
ira.AdicionarNota(new Avaliacao(10));
ira.AdicionarNota(new Avaliacao(9));
ira.AdicionarNota(new Avaliacao(8));
Banda beatles = new Banda("Beatles!");

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(beatles.Nome, beatles);


void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            ExibirDetalhes();
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarAlbum()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de álbuns");
    Console.Write("Digite a banda cujo álbum deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.Write("Agora digite o título do álbum: ");
        string tituloAlbum = Console.ReadLine()!;
        Banda banda = bandasRegistradas[nomeBanda];
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
    ExibirOpcoesDoMenu();
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Banda banda = new Banda(nomeDaBanda);
    bandasRegistradas.Add(nomeDaBanda, banda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Bandas registradas");

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteristicos = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(asteristicos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteristicos + "\n");
}

void AvaliarBanda()
{
    Console.Clear();
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
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"O nome da {nomeBanda} não foi encontrado!");
        Console.WriteLine("Digite alguma tecla para voltar ao menu!");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirDetalhes()
{
    Console.Clear();
    ExibirTituloDaOpcao("Média da nota de uma banda");
    Console.Write("Digite o nome da banda que deseja ver a média: ");
    string nomeBanda = Console.ReadLine()!;

    if(bandasRegistradas.ContainsKey(nomeBanda))
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
        ExibirOpcoesDoMenu();
    }
}

ExibirOpcoesDoMenu();