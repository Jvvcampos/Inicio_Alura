using ScreenSound04.Filtros;
using ScreenSound04.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGenero(musicas, "pop");
        //LinqFilter.FiltrarMusicasArtista(musicas, "Eminem");
        //LinqFilter.FiltrarMusicasAno(musicas, "2014");

        var musicasPreferidas = new MusicasPreferidas("Joao");
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[2]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[3]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[4]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[5]);

        musicasPreferidas.ExibirMusicasFavoritas();
        musicasPreferidas.GerarArquivoJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }

}