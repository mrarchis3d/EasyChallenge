using System.Text.Json.Serialization;

namespace FizzBuzzLibrary.Domain;

public class TokenMap
{
    [JsonPropertyName("multiple")]
    public int Multiple { get; set; }
    [JsonPropertyName("word")]
    public string Word { get; set; }
}
