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
}
