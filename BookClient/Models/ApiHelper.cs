using System.Threading.Tasks;
using RestSharp;

namespace BookClient.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5000/api/");
      RestRequest request = new RestRequest($"bookAPIs");
      IRestResponse response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api/");
      RestRequest request = new RestRequest($"bookAPIs/{id}", Method.GET);
      IRestResponse response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task Post(string newBook)
    {
      RestClient client = new RestClient("http://localhost:5000/api/");
      RestRequest request = new RestRequest($"bookAPIs", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newBook);
      IRestResponse response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Put(int id, string newBook)
    {
      RestClient client = new RestClient("http://localhost:5000/api/");
      RestRequest request = new RestRequest($"bookAPIs", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newBook);
      IRestResponse response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Delete(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api/");
      RestRequest request = new RestRequest($"bookAPIs/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      IRestResponse response = await client.ExecuteTaskAsync(request);
    }

    public static async Task<string> Search(string title, string author, string genre, int rating)
    {
      RestClient client = new RestClient("http://localhost:5000/api/");
      RestRequest request = new RestRequest($"bookAPIs/?title={title}&author={author}&genre={genre}&rating={rating}", Method.GET);
      IRestResponse response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}