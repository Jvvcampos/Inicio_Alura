using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


partial class Program
{
    static void FileStreamDireto()
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var numeroDeBytesLidos = -1;
            var buffer = new byte[1024]; //1KB

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer, numeroDeBytesLidos);
            }

            fluxoDoArquivo.Close();
            Console.ReadLine();
        }
    }

    static void EscreverBuffer(byte[] buffer, int numeroDeBytesLidos)
    {
        var utf8 = new UTF8Encoding();

        var texto = utf8.GetString(buffer, 0, numeroDeBytesLidos);
        Console.Write(texto);
        /*
        foreach(var meuByte in buffer)
        {
            Console.Write(meuByte);
            Console.Write (" ");
        }*/
    }
}

