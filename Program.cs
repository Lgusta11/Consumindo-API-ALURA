using System.Text.Json;
using GY.Filtros;
using GY.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        string Resposta = await client.GetStringAsync(
            "https://guilhermeonrails.github.io/api-csharp-songs/songs.json"
        );

        var musicas = JsonSerializer.Deserialize<List<Musica>>(Resposta)!;

        LinqFilter.FiltrarMusicasCsharp(musicas);
          // musicas[0].ExibirDestalhesDaMusica();
        // LinqFilter.FiltrarGeneros(musicas);
        // LinqOrdem.ExibirListaArtistas(musicas);
        //LinqFilter.FiltrarArtistaPorGenero(musicas, "rock");
        //LinqFilter.FiltrarMusicaDeUmArtista(musicas, "U2");



        // var MusicasPreferidasGusta = new MusicasPreferidas("Gusta");
         //MusicasPreferidasGusta.AdcMusicasFavoritas(musicas[1]);
         //MusicasPreferidasGusta.AdcMusicasFavoritas(musicas[324]);
         //MusicasPreferidasGusta.AdcMusicasFavoritas(musicas[65]);
         //MusicasPreferidasGusta.AdcMusicasFavoritas(musicas[122]);
         //MusicasPreferidasGusta.AdcMusicasFavoritas(musicas[76]);

         //MusicasPreferidasGusta.ExibirMusicasPreferidas();
         //MusicasPreferidasGusta.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}
