using System.Threading.Tasks;
using RestSharp;

namespace Survivor.Models
{
  class ApiHelper
  {
    public static async Task<string> PlayerApiCall()
    {
      RestClient client = new RestClient("http://localhost:5000/api/players/");
      RestRequest request = new RestRequest(Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
    public static async Task<string> SeasonApiCall()
    {
        RestClient client = new RestClient("http://localhost:5000/api/seasons/");
        RestRequest request = new RestRequest(Method.GET);
        var response = await client.ExecuteTaskAsync(request);
        return response.Content;
    }
    public static async Task<string> AuthApiCall(User1 user)
    {      
        RestClient client = new RestClient("http://localhost:5000/users/authenticate");
        RestRequest request = new RestRequest(Method.POST);
        request.AddJsonBody(user);
        var response = await client.ExecuteTaskAsync(request);
        return response.Content;
    }

    public static async Task<string> NewUserApiCall(User1 newUser)
    {
        RestClient client = new RestClient("http://localhost:5000/users/create");
        RestRequest request = new RestRequest(Method.POST);
        request.AddJsonBody(newUser);
        var response = await client.ExecuteTaskAsync(request);
      
        return response.Content;
    }

      public static async Task<string> NewPlayerApiCall(Player player)
    {
        RestClient client = new RestClient("http://localhost:5000/api/players/");
        RestRequest request = new RestRequest(Method.POST);
        request.AddJsonBody(player);
        var response = await client.ExecuteTaskAsync(request);
      
        return response.Content;
    }
  }
}