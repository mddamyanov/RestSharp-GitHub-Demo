using System.Text.Json.Serialization;

public class Place
{
    [JsonPropertyName("place name")]
    public string PlaceName { get; set; }

    [JsonPropertyName("state")]
    public string State { get; set; }

    [JsonPropertyName("state abbreviation")]
    public string StateAbbreviation { get; set; }

    [JsonPropertyName("latitude")]
    public string Latitude { get; set; }

    [JsonPropertyName("longtitude")]
    public string Longtitude { get; set; }
}