using NUnit.Framework;
using RestSharp;
using RestSharp.Serializers.Json;
using System.Threading.Tasks;

namespace TestZipopotamusApi
{
    public class ZipopotamusApiTests
    {
        [TestCase("BG", "1000", "Sofija")]
        [TestCase("BG", "8600", "Jambol")]
        [TestCase("CA", "M5S", "Toronto")]
        [TestCase("GB", "B1", "Birmingham")]
        [TestCase("DE", "01067", "Dresden")]

        public async Task TestZipopotamus(string countryCode, string zipCode, string expectedPlace)
        {
            //Arange
            var client = new RestClient("https://api.zippopotam.us");
            var request = new RestRequest(countryCode + "/" + zipCode);

            //Act
            var response = await client.GetAsync(request);
            var location = new SystemTextJsonSerializer().Deserialize<Location>(response);

            //Assert
            StringAssert.Contains(expectedPlace, location.Places[0].PlaceName);
        }
    }
}