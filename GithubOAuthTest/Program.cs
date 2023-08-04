// See https://aka.ms/new-console-template for more information
using RestSharp;

Console.WriteLine ("Hello, World!");

string clientID = "19e4d0b97a3e5d12fa7c";
RestClient restClient = new RestClient ($"https://github.com/login/oauth/authorize?client_id={clientID}");

var request = new RestRequest ();
var restRespone = restClient.Execute (request);

if(restRespone.IsSuccessful == true)
{
    Console.WriteLine ("Hello, World!");
}
else
{
    Console.WriteLine ("Hello, World!");
}

Console.WriteLine ("Hello, World!");