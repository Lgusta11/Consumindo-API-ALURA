namespace GY.Filtros;
using GY.Modelos;

internal class LinqOrdem
{
  public static void ExibirListaArtistas(List<Musica> musicas)
  {
    var artistasOrdenados = musicas.OrderBy(musicas => musicas.Artista).Select(musica => musica.Artista).Distinct().ToList();
    Console.WriteLine("Lista de Artista ordenados");
    foreach (var artista in artistasOrdenados)
    {
      Console.WriteLine($"- {artista}");
    }
  }
}
