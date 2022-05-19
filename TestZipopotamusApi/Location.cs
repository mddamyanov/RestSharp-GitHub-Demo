using System.Collections.Generic;
using System.Text.Json.Serialization;

public class Location
{
    [JsonPropertyName("post code")]
    public string postCode { get; set; }

    [JsonPropertyName("country")]
    public string Country { get; set; }

    [JsonPropertyName("country abbreviation")]
    public string CountryAbbreviation { get; set; }

    [JsonPropertyName("places")]
    public List<Place> Places { get; set; }
}