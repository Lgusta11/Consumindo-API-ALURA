using System.Text.Json;
using GY.Modelos;
using GY.Filtros;
using (HttpClient client = new HttpClient())
{
  try
  {
    string Resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
  
    var musicas = JsonSerializer.Deserialize<List<Musica>>(Resposta)!;
    musicas[0].ExibirDestalhesDaMusica();
   // LinqFilter.FiltrarGeneros(musicas);
   // LinqOrdem.ExibirListaArtistas(musicas);
   LinqFilter.FiltrarArtistaPorGenero(musicas, "rock");

  }
  catch (Exception ex)
  {
    Console.WriteLine($"Error: {ex.Message}");
  }


}
