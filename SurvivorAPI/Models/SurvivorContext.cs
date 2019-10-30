using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;

namespace Survivor.Models

{
    public class SurvivorContext : DbContext
    {
        public SurvivorContext(DbContextOptions<SurvivorContext> options) : base(options)
        {
        } 

        public DbSet<Player> Players {get; set;}
        public DbSet<Season> Seasons {get; set;}
        public DbSet<Appearance> Appearances {get; set;}
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            builder.Entity<Player>().HasData(
                new Player {
                    PlayerId = 1, 
                    PlayerName = "Boston Rob", 
                    TotalDays = 117,
                    Gender = "Male",
                    BirthYear =  1975,
                    },
                    new Player {
                    PlayerId = 2, 
                    PlayerName = "Peter Harkey", 
                    TotalDays = 0,
                    Gender = "Male",
                    BirthYear =  1956,
                   
                    },
                    new Player {
                    PlayerId = 3, 
                    PlayerName = "Patricia Jackson", 
                    TotalDays = 0,
                    Gender = "Female",
                    BirthYear =  1952,
                   
                    },
                    new Player {
                    PlayerId = 4, 
                    PlayerName = "Hunter Ellis", 
                    TotalDays = 0,
                    Gender = "Male",
                    BirthYear =  1968,
                   
                    },
                    new Player {
                    PlayerId = 5, 
                    PlayerName = "Sarah Jones", 
                    TotalDays = 0,
                    Gender = "Female",
                    BirthYear =  1977,
                   
                    },
                    new Player {
                    PlayerId = 6, 
                    PlayerName = "Gabriel Cade", 
                    TotalDays = 0,
                    Gender = "Male",
                    BirthYear =  1978,
                   
                    },
                    new Player {
                    PlayerId = 7, 
                    PlayerName = "Vecepia Towery", 
                    TotalDays = 0,
                    Gender = "Female",
                    BirthYear = 1965,
                    Winner = true
                   
                    }
            );

            builder.Entity<Season>().HasData(
                new Season {
                    SeasonId = 4, 
                    SeasonName = "Marquesas" 
                    
                    }
            );
            builder.Entity<Appearance>().HasData(
                new Appearance {
                    SeasonId = 4, 
                    PlayerId = 1,
                    AppearanceId = 1,
                    DaysPerSeason = 11,
                    GameAge = 25
                    }
            );
        }
    }
}