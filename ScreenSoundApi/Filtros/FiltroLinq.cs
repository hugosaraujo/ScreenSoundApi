﻿using ScreenSoundApi.Modelos;
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
}
