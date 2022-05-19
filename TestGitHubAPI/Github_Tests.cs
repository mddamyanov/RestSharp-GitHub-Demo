using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace TestGitHubAPI
{
    public class Github_Tests
    {
        private RestClient client;
        private RestRequest request;
        [SetUp]
        public void Setup()
        {
            this.client = new RestClient("https://api.github.com");
            this.client.Authenticator = new HttpBasicAuthenticator("mddamyanov", "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");
            string url = "/repos/mddamyanov/Postman/issues";

            this.request = new RestRequest(url);
        }

        [Test]
        public async Task Test_Get_Issues()
        {
            var response = await client.ExecuteAsync(request);

            var issues = JsonSerializer.Deserialize<List<Issues>>(response.Content);

            foreach (var issue in issues)
            {
                Assert.IsNotNull(issue.html_url);
            }

            Assert.IsNotNull(response);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}