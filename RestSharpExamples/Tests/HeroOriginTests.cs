using NUnit.Framework;
using RestSharp;
using RestSharp.Deserializers;
using RestSharpExamples.DataEntities;

namespace RestSharp.Tests
{
    [TestFixture]
    public class HeroOriginTests
    {
        [Test]
        public void LukeOriginTest()
        {           
            RestClient client = new RestClient("https://swapi.dev/api/");
            RestRequest request = new RestRequest("people/1/", Method.GET);

            IRestResponse response = client.Execute(request);

            HeroResponse heroResponse =
                new JsonDeserializer().
                Deserialize<HeroResponse>(response);

            var planet = heroResponse.Homeworld.Substring(30);

            client = new RestClient("https://swapi.dev/api/");
            request = new RestRequest("planets/"+planet, Method.GET);

            response = client.Execute(request);

            PlanetResponse planetResponse =
                new JsonDeserializer().
                Deserialize<PlanetResponse>(response);

            Assert.That(planetResponse.Name, Is.EqualTo("Tatooine"));
        }
    }
}