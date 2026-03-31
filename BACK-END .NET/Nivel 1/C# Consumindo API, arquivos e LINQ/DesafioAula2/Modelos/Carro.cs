using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DesafioAula2.Modelos
{
    internal class Carro
    {
        [JsonPropertyName("marca")]
        public string Marca { get; set; }
        [JsonPropertyName("modelo")]
        public string Modelo { get; set; }
        [JsonPropertyName("ano")]
        public int Ano { get; set; }

        public void FichaVeicular()
        {
            Console.WriteLine("Deserializando carro");
            Console.WriteLine("Dados do carro:");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}\n");
        }
    }
}
