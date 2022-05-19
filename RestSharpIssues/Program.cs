using RestSharp;
using System;
using System.Collections.Generic;
using System.Text.Json;

var client = new RestClient("https://api.github.com");

var url = "/repos/mddamyanov/Postman/issues";

var request = new RestRequest(url);

var response = await client.ExecuteAsync(request);

var issues = JsonSerializer.Deserialize<List<Issues>>(response.Content);

foreach (var issue in issues)
{
    Console.WriteLine("Issue Number: " + issue.number);
    Console.WriteLine("Issue ID: " + issue.id);
    Console.WriteLine("Issue URL: " + issue.url);
    Console.WriteLine("*****");
}
