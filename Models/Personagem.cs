using System.Text.Json.Serialization;

namespace BlazorDbzPersonagem.Models
{
    // Representa o personagem retornado pela API
    public class Personagem
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Nome { get; set; } = string.Empty;

        [JsonPropertyName("image")]
        public string Imagem { get; set; } = string.Empty;

        [JsonPropertyName("originPlanet")]
        public Planeta? PlanetaOrigem { get; set; }

        [JsonPropertyName("transformations")]
        public List<Transformacao> Transformacoes { get; set; } = new();
    }

    // Representa o planeta de origem do personagem
    public class Planeta
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Nome { get; set; } = string.Empty;
    }

    // Representa uma transformação do personagem
    public class Transformacao
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Nome { get; set; } = string.Empty;

        [JsonPropertyName("ki")]
        public string Ki { get; set; } = string.Empty;
    }
}
