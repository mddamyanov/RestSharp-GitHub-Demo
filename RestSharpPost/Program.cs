using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Text.Json;

var client = new RestClient("https://api.github.com");
client.Authenticator = new HttpBasicAuthenticator("mddamyanov", "ENTERTOKEN");

string url = "/repos/mddamyanov/Postman/issues";

var request = new RestRequest(url);
request.AddBody(new { title = "New Issue from RestSharp" });
var response = await client.ExecuteAsync(request, Method.Post);

Console.WriteLine("Status Code: " + response.StatusCode);
Console.WriteLine("Status Code: " + response.Content);
