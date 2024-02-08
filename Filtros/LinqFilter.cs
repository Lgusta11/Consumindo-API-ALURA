namespace GY.Filtros;
using GY.Modelos;
internal class LinqFilter
{
  public static void FiltrarGeneros(List<Musica> musicas)
  {

    var GenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
    foreach (var genero in GenerosMusicais)
    {
      Console.WriteLine($"- {genero}");
    }
  }

  public static void FiltrarArtistaPorGenero(List<Musica> musicas, string genero)
  {
    var ArtistaPorGenero = musicas.Where(musicas => musicas.Genero!.Contains(genero))
    .Select(musica => musica.Artista).Distinct().ToList();
    Console.WriteLine($"Exibindo os Artistas por genero >>> { genero}");
    foreach (var artista in ArtistaPorGenero)
    {
      Console.WriteLine($"- {artista}");
    }

  }


}

