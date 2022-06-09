using Newtonsoft.Json;

namespace RestSharpExamples.DataEntities
{
    public class PlanetResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
