using ScreenSoundApi.Modelos;
using System.Linq;

namespace ScreenSoundApi.Filtros;

internal class FiltroLinq
{
    //Exibir todos os gêneros musicais;
    public static void FiltrarGenerosMusicais(List<Musica> musicas)
    {
        var todosGeneros = musicas.Select(musica => musica.Genero).
            Distinct().
            ToList();
        foreach (var genero in todosGeneros)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGenero(List<Musica>musica, string genero)
    {
        var artistasPorGeneroMusical = musica.Where(musica => musica.Genero.Contains(genero))
            .OrderBy(musica => musica.Artista)
            .Select(musica => musica.Artista)
            .Distinct()
            .ToList();
        Console.WriteLine($"Exibindo uma lista de artistas por gênero musical -> {genero}");
        foreach(var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasPorArtista(List<Musica> musicas, string artista)
    {
        //Criar uma validação para quando o Artista pesquisado não tiver musicas registradas
        
        var musicasPorArtista = musicas.Where(musica => musica.Artista.Equals(artista))
            .OrderBy(musica => musica.Nome)
            .Select(musica => musica.Nome)
            .ToList();
        Console.WriteLine($"Exibindo uma lista de músicas por artista -> {artista}");
        foreach (var musica in musicasPorArtista)
        {
            Console.WriteLine($"- {musica}");
        }
    }   

    public static void FiltrarMusicasPorAnoDeLancamento(List<Musica> musicas, int ano)
    {
        var musicasPorAnoDeLancamento = musicas.Where(musica => musica.Ano.Equals(ano))
            .OrderBy(musica => musica.Artista)
            .Select(musica => musica.Nome)
            .Distinct()
            .ToList();
        Console.WriteLine($"Exibindo uma lista de músicas por ano de lançamento -> {ano}");
        foreach (var musica in musicasPorAnoDeLancamento)
        {
            Console.WriteLine($"- {musica}");
        }
    }
    public static void FiltrarMusicaPorTonalidade(List<Musica> musicas, string tonalidade)
    {
        var musicasPorTonalidade = musicas.Where(musica => musica.Tonalidade.Equals(tonalidade))
            .OrderBy(musica => musica.Nome)
            .Select(musica => musica.Nome)
            .Distinct()
            .ToList();
        Console.WriteLine($"Exibindo uma lista de músicas pela tonalidade -> {tonalidade}");
        foreach (var musica in musicasPorTonalidade)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
