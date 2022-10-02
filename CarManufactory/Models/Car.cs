using System.Text.Json.Serialization;

namespace CarManufactory.Models
{
    public class Car
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("manufacturer")]
        public string Manufacturer {get; set; }
        [JsonPropertyName("model")]
        public string Model {get; set;}
        [JsonPropertyName("color")]
        public string Color{get; set; }
        [JsonPropertyName("hp")]
        public int Hp    {get; set; }
        [JsonPropertyName("engine")]
        public int Engine   {get; set; }
        [JsonPropertyName("fuel")]
        public string Fuel  {get; set; }
    }
}
