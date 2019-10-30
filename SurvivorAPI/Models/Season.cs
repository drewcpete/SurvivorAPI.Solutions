using System.Collections.Generic;

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
    }
}