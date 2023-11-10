using ScreenSoundApi.Modelos;
using System.Linq;

namespace ScreenSoundApi.Filtros;

internal class FiltroLinq
{
    //Exibir todos os gêneros musicais;
    public static void FiltrarGenerosMusicais(List<Musica> musicas)
    {
        var todosGeneros = musicas.Select(musica => musica.Genero).Distinct().ToList();
        foreach (var genero in todosGeneros)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGenero(List<Musica>musica, string genero)
    {
        var artistasPorGeneroMusical = musica.OrderBy(musica => musica.Artista).Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo uma lista de artistas por gênero musical -> {genero}");
        foreach(var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
