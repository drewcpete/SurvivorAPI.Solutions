using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
 

 namespace Survivor.Models
 {
     public class User
     {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public ICollection<Player> Players {get;set;}
        public ICollection<Season> Seasons { get; set; }
        public User()
        {
            this.Players = new HashSet<Player> () ;
            this.Seasons = new HashSet<Season> () ;
        }

    public static List<Player> GetPlayers()
        {
            var apiCallTask = ApiHelper.PlayerApiCall();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Player> playerList = JsonConvert.DeserializeObject<List<Player>>(jsonResponse.ToString());

            return playerList;
        }
     }
 }