using RestSharp;
using System;
using System.Collections.Generic;
using System.Text.Json;

var client = new RestClient("https://api.github.com");

var request = new RestRequest("/users/mddamyanov/repos");

var response = await client.ExecuteAsync(request);

var repos = JsonSerializer.Deserialize<List<Repo>>(response.Content);

foreach (var repo in repos)
{
    Console.WriteLine("Repo Full Name: " + repo.full_name);
}
