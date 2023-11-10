using ScreenSoundApi.Filtros;
using ScreenSoundApi.Modelos;
using System.Text.Json;
using ScreenSoundApi.Filtros;

using (HttpClient cliente = new HttpClient())
{
    try
    {
        string resposta = await cliente.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //FiltroLinq.FiltrarGenerosMusicais(musicas);
        OrdenadorLinq.ExibirArtistasOrdenados(musicas);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}