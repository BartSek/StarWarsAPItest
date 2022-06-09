using Newtonsoft.Json;
using System.Collections.Generic;

namespace RestSharpExamples.DataEntities
{
    public class HeroResponse
    {
        [JsonProperty("homeworld")]
        public string Homeworld { get; set; }
    }
}
