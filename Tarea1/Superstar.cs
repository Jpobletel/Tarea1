using Newtonsoft.Json;

namespace Tarea1;

public class Superstar
{
    [JsonProperty("name")]
    public string Name { get; set; } 

    [JsonProperty("HandSize")]
    public int HandSize { get; set; }

    [JsonProperty("StarValue")]
    public int StarValue { get; set; }

    [JsonProperty("SuperStarAbility")]
    public string SuperStarAbility { get; set; }
    
}

