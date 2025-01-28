using ConsumindoApi;
using System.Net.Http.Json;

var client = new HttpClient();


var response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts");

var posts = await response.Content.ReadFromJsonAsync<List<Post>>();

if (response.IsSuccessStatusCode)
{
    Console.WriteLine("Sucesso!");
}
else
{
    Console.WriteLine($"Deu ruim: {response.StatusCode}");
}

for (int i = 0; i < 5; i++)  
{
    Console.WriteLine($"Id:{posts[i].Id} - Title: {posts[i].Title} - Body: {posts[i].Body}");
}

Console.ReadLine();