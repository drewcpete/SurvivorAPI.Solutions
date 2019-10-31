﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Survivor.Models;

namespace Survivor.Migrations
{
    [DbContext(typeof(SurvivorContext))]
    [Migration("20191031181952_UdtateAPI")]
    partial class UdtateAPI
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Survivor.Models.Appearance", b =>
                {
                    b.Property<int>("AppearanceId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DaysPerSeason");

                    b.Property<int>("GameAge");

                    b.Property<int>("PlayerId");

                    b.Property<int>("SeasonId");

                    b.HasKey("AppearanceId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("SeasonId");

                    b.ToTable("Appearances");

                    b.HasData(
                        new
                        {
                            AppearanceId = 1,
                            DaysPerSeason = 11,
                            GameAge = 25,
                            PlayerId = 1,
                            SeasonId = 4
                        });
                });

            modelBuilder.Entity("Survivor.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BirthYear");

                    b.Property<string>("Gender");

                    b.Property<string>("PlayerName")
                        .IsRequired();

                    b.Property<int>("TotalDays");

                    b.Property<bool>("Winner");

                    b.HasKey("PlayerId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            PlayerId = 1,
                            BirthYear = 1975,
                            Gender = "Male",
                            PlayerName = "Boston Rob",
                            TotalDays = 117,
                            Winner = false
                        },
                        new
                        {
                            PlayerId = 2,
                            BirthYear = 1956,
                            Gender = "Male",
                            PlayerName = "Peter Harkey",
                            TotalDays = 0,
                            Winner = false
                        },
                        new
                        {
                            PlayerId = 3,
                            BirthYear = 1952,
                            Gender = "Female",
                            PlayerName = "Patricia Jackson",
                            TotalDays = 0,
                            Winner = false
                        },
                        new
                        {
                            PlayerId = 4,
                            BirthYear = 1968,
                            Gender = "Male",
                            PlayerName = "Hunter Ellis",
                            TotalDays = 0,
                            Winner = false
                        },
                        new
                        {
                            PlayerId = 5,
                            BirthYear = 1977,
                            Gender = "Female",
                            PlayerName = "Sarah Jones",
                            TotalDays = 0,
                            Winner = false
                        },
                        new
                        {
                            PlayerId = 6,
                            BirthYear = 1978,
                            Gender = "Male",
                            PlayerName = "Gabriel Cade",
                            TotalDays = 0,
                            Winner = false
                        },
                        new
                        {
                            PlayerId = 7,
                            BirthYear = 1965,
                            Gender = "Female",
                            PlayerName = "Vecepia Towery",
                            TotalDays = 0,
                            Winner = true
                        });
                });

            modelBuilder.Entity("Survivor.Models.Season", b =>
                {
                    b.Property<int>("SeasonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Location");

                    b.Property<int>("ReleaseYear");

                    b.Property<string>("SeasonName");

                    b.HasKey("SeasonId");

                    b.ToTable("Seasons");

                    b.HasData(
                        new
                        {
                            SeasonId = 4,
                            ReleaseYear = 0,
                            SeasonName = "Marquesas"
                        });
                });

            modelBuilder.Entity("Survivor.Models.User1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("Token");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "test",
                            LastName = "test",
                            Password = "admin",
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("Survivor.Models.Appearance", b =>
                {
                    b.HasOne("Survivor.Models.Player", "Player")
                        .WithMany("SeasonsPlayed")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Survivor.Models.Season", "Season")
                        .WithMany("PlayersInSeason")
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
