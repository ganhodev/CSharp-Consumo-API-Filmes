using CSharp_Consumo_API_Filmes_;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        var filmes = JsonSerializer.Deserialize<List<Filme>>(resposta)!;
        if (filmes != null && filmes.Count > 0)
        {
            filmes[10].ExibirDetalhesDoFilme();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro encontrado: {ex.Message}");
    }
}