using DesafioAula2.Modelos;
using System.Text.Json;

using(HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        var filmes = JsonSerializer.Deserialize<List<Filme>>(response);
        filmes[6].ExibirFichaTecnica();

        response = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        var paises = JsonSerializer.Deserialize<List<Pais>>(response);
        paises[1].ExibirPais();

        response = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
        var veiculos = JsonSerializer.Deserialize<List<Carro>>(response);
        veiculos[2].FichaVeicular();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
