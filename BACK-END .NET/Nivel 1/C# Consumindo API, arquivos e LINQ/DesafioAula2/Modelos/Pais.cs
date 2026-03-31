using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DesafioAula2.Modelos
{
    internal class Pais
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }
        [JsonPropertyName("capital")]
        public string Capital { get; set; }
        [JsonPropertyName("idioma")]
        public string Idioma { get; set; }

        public void ExibirPais()
        {
            Console.WriteLine("Deserializando País!");
            Console.WriteLine("Dados do país:");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Capital: {Capital}");
            Console.WriteLine($"Idioma: {Idioma}\n");
        }
    }
}
