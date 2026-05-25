using System.Text.Json.Serialization;

namespace CSharp_Consumo_API_Filmes_;

internal class Filme
{
    [JsonPropertyName("title")]
    public string? Titulo { get; set; }

    [JsonPropertyName("year")]
    public string? Ano { get; set; }

    public void ExibirDetalhesDoFilme()
    {
        Console.WriteLine($"Nome: {Titulo}");
        Console.WriteLine($"Ano de publicação: {Ano}");
    }
}
