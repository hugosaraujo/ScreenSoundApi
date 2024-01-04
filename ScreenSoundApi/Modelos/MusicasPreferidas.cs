using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ScreenSoundApi.Modelos
{
    internal class MusicasPreferidas
    {
        private List<Musica> listaDeMusicasFavoritas = new List<Musica>();

        public MusicasPreferidas(string nome)
        {
            Nome = nome;
            listaDeMusicasFavoritas = new List<Musica>();
        }
        public string? Nome { get; set; }
        public IEnumerable<Musica> MusicasFavoritas => listaDeMusicasFavoritas;

        public void AdicionarMusica(Musica musica)
        {
            listaDeMusicasFavoritas.Add(musica);
        }

        public void ExibirMusicas()
        {
            Console.WriteLine($"Essas são as músicas favoritas do {Nome}");
            foreach (var musica in MusicasFavoritas)
            {
                Console.WriteLine($"Musica: {musica.Nome} - Artista: {musica.Artista}");
            }
            Console.WriteLine();
        }

        public void GerarArquivoJson()
        {
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                musicas = MusicasFavoritas
            });
            string nomeArquivo = $"musicas_favoritas_{Nome}.json";
            File.WriteAllText(nomeArquivo, json);
            Console.WriteLine($"Arquivo json criado com sucesso {Path.GetFullPath(nomeArquivo)}");
            Thread.Sleep(2000);
        }
    }
}
