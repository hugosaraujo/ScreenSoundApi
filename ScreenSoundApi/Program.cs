using ScreenSoundApi.Filtros;
using ScreenSoundApi.Modelos;
using System.Text.Json;
using ScreenSoundApi.Filtros;
using ScreenSoundApi;

using (HttpClient cliente = new HttpClient())
{
    try
    {
        string resposta = await cliente.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //musicas[1900].ExibirDetalhes();
        //Console.WriteLine(resposta);
        //FiltroLinq.FiltrarGenerosMusicais(musicas);
        //OrdenadorLinq.ExibirArtistasOrdenados(musicas);
        //FiltroLinq.FiltrarArtistasPorGenero(musicas, "pop");
        //FiltroLinq.FiltrarMusicasPorArtista(musicas, "Red Hot Chili Peppers");
        //FiltroLinq.FiltrarMusicasPorAnoDeLancamento(musicas, 2010);

        //var musicasPreferidas = new MusicasPreferidas("Emilly");
        //musicasPreferidas.AdicionarMusica(musicas[23]);
        //musicasPreferidas.AdicionarMusica(musicas[27]);
        //musicasPreferidas.AdicionarMusica(musicas[181]);
        //musicasPreferidas.AdicionarMusica(musicas[870]);
        //musicasPreferidas.AdicionarMusica(musicas[987]);
        //musicasPreferidas.ExibirMusicas();
        //musicasPreferidas.GerarArquivoTXT();
        FiltroLinq.FiltrarMusicaPorTonalidade(musicas, "C");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}