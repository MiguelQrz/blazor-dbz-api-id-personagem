using System.Text.Json.Serialization;

namespace BlazorDragonBallApi.Models
{
    public class Character
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("originPlanet")]
        public Planet? OriginPlanet { get; set; }

        [JsonPropertyName("transformations")]
        public List<Transformation> Transformations { get; set; } = new();
    }

    public class Planet
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }

    public class Transformation
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }
}