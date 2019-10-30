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
  }
}