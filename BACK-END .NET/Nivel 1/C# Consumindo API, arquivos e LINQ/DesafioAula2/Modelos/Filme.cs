using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DesafioAula2.Modelos
{
    internal class Filme
    {
        [JsonPropertyName("title")]
        public string Titulo { get; set; }
        [JsonPropertyName("year")]
        public string AnoLançado { get; set; }
        [JsonPropertyName("crew")]
        public string Elenco { get; set; }

        public void ExibirFichaTecnica()
        {
            Console.WriteLine("Deserializando filme!");
            Console.WriteLine("Ficha técnica do filme:");
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Ano de lançamento: {AnoLançado}");
            Console.WriteLine($"Elenco: {Elenco}\n");
        }
    }
}
