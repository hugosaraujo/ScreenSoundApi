using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;
using System.Xml;

namespace ScreenSoundApi.Modelos;

internal class Musica
{
    private List<string> tonalide = new List<string>(){"C","C#","D","D#","E","F","F#", "G","G#","A","A#","B"};
    
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    [JsonPropertyName("key")]
    public int Key { get; set; }
    public string Tonalidade { 
        get
        {
            return tonalide[Key];
        }
    }
    [JsonPropertyName("year")]
    public string? AnoString { get; set; }
    public int Ano 
    { 
        get
        {
            return int.Parse(AnoString!);
        }
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duracao: {Duracao/1000}");
        Console.WriteLine($"Genero Musical: {Genero}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
    }
}
