using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoArquivo = "ContasExportadas.csv";

        using (var fluxoArquivo = new FileStream(caminhoArquivo, FileMode.Create))
        {
            var contaString = "456, 7895, 97863.40, Gustavo Almeida";

            var enconding = Encoding.UTF8;

            var bytes = enconding.GetBytes(contaString);

            fluxoArquivo.Write(bytes, 0, bytes.Length);
        }
    }

    static void CriarArquivoComWriter()
    {
        var caminhoArquivo = "ContasExportadas.csv";

        using (var fluxoArquivo = new FileStream(caminhoArquivo, FileMode.Create))
        using(var escritor = new StreamWriter(fluxoArquivo))
        {
            escritor.Write("456,7895,97863.40,Pedro");
        }

    }
    static void TestaEscrita()
    {
        var caminhoNovoArquivo = "teste.txt";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            for (int i = 0; i < 1000000; i++)
            {
                escritor.WriteLine($"Linha {i}");
                escritor.Flush();
                Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter p adicionar mais uma!");
                Console.ReadLine();
            }
        }
    }
}
