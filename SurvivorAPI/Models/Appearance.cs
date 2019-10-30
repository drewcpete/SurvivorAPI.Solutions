using System.Collections.Generic;

namespace Survivor.Models
{
    public class Appearance
    {
       public int AppearanceId {get;set;}
       public int PlayerId {get;set;}
       public int SeasonId {get;set;}
       public int DaysPerSeason { get; set;}
       public int GameAge { get; set; }
       public Player Player {get; set;}
       public Season Season {get;set;}
    }
}