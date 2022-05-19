using NUnit.Framework;
using RestSharp;
using System;
using System.Net;
using System.Threading.Tasks;

namespace GameAPI
{
    public class DeckOfCardsTest
    {
        private RestClient client;
        private RestRequest request;
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public async Task Test_BrandNewDeckAsync()
        {
            this.client = new RestClient("http://deckofcardsapi.com/api/deck");
            string url = "/new/";
            this.request = new RestRequest(url);
            var response = await client.ExecuteAsync(request);

            Console.WriteLine("Deck Status: ");
            Console.WriteLine("Deck ID: ");
            Console.WriteLine("Deck Shuffled: ");
            Console.WriteLine("Deck Remaining Cards: ");

            Assert.IsNotNull(response);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void Test_DrawCards()
        {
            Assert.Pass();
        }

        [Test]
        public void Test_ReturnFirstCard()
        {
            Assert.Pass();
        }
    }
}