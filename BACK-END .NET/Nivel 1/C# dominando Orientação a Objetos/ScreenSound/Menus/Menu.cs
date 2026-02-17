using ScreenSound.Modelos;

namespace ScreenSound.Menus;
internal class Menu
{
    public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
    }

    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeLetras = titulo.Length;
        string asteristicos = string.Empty.PadLeft(quantidadeLetras, '*');
        Console.WriteLine(asteristicos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteristicos + "\n");
    }
}

