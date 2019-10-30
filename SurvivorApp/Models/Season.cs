using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Survivor.Models
{
    public class Season
    {
        public int SeasonId { get; set; }
        public string SeasonName { get; set; }
        public string Location { get; set; }
        public int ReleaseYear { get; set; }
        
        public ICollection<Appearance> PlayersInSeason {get; set;}
        public Season()
        {
            this.PlayersInSeason = new HashSet<Appearance>();
        }
        public static List<Season> GetSeasons()
        {
            var apiCallTask = ApiHelper.SeasonApiCall();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Season> seasonList = JsonConvert.DeserializeObject<List<Season>>(jsonResponse.ToString());

            return seasonList;
        }
    }
}