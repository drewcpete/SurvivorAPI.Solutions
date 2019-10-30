using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;




namespace Survivor.Models
{
    public class Player
    {
        public int PlayerId { get; set; }

        [Required]
        public string PlayerName { get; set; }
        public ICollection<Appearance> SeasonsPlayed { get; set; }
        public int TotalDays { get; set; }
        public string Gender { get; set; }
        public int BirthYear { get; set; }
        public bool Winner { get; set; }
        public Player()
        {
            this.SeasonsPlayed = new HashSet<Appearance>();
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