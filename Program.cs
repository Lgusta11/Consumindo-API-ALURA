using (HttpClient client = new HttpClient())
{
  try
  {
    string Resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    Console.WriteLine(Resposta);
  }
  catch (Exception ex)
  {
    Console.WriteLine($"Error: {ex.Message}");
  }


}
