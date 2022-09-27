using Newtonsoft.Json; 

namespace Tarea1;

public class Carta
{
    [JsonProperty("Title")]
    public string Title { get; set; }

    [JsonProperty("Types")]
    public List<string> Types { get; set; }

    [JsonProperty("Subtypes")]
    public List<string> Subtypes { get; set; }

    [JsonProperty("Fortitude")]
    public string Fortitude { get; set; }

    [JsonProperty("Damage")]
    public string Damage { get; set; }

    [JsonProperty("StunValue")]
    public string StunValue { get; set; }

    [JsonProperty("CardEffect")]
    public string CardEffect { get; set; }
    
    
}