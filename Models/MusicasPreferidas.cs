namespace GY.Modelos
{
    using System.Collections.Generic;
    using System.Text.Json;
    using System.IO; // Adicionando referência para System.IO

    internal class MusicasPreferidas
    {
        public string Nome { get; set; }
        public List<Musica> ListaDeMusicasPreferidas { get; }

        public MusicasPreferidas(string nome)
        {
            Nome = nome;
            ListaDeMusicasPreferidas = new List<Musica>();
        }

        public void AdcMusicasFavoritas(Musica musica)
        {
            ListaDeMusicasPreferidas.Add(musica);
        }

        public void ExibirMusicasPreferidas()
        {
            Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");
            foreach (var musica in ListaDeMusicasPreferidas)
            {
                Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
            }
            Console.WriteLine();
        }

        public void GerarArquivoJson()
        {
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                musicas = ListaDeMusicasPreferidas
            });
            string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
            File.WriteAllText(nomeDoArquivo, json);
            Console.WriteLine("Arquivo criado {Path.GetFullPath(nomeDoArquivo)}");
        }
    }
}
