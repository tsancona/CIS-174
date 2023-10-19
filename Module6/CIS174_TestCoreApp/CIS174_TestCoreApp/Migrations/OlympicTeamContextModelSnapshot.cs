﻿// <auto-generated />
using CIS174_TestCoreApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CIS174_TestCoreApp.Migrations
{
    [DbContext(typeof(OlympicTeamContext))]
    partial class OlympicTeamContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CIS174_TestCoreApp.Models.OlympicCategory", b =>
                {
                    b.Property<string>("OlympicCategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OlympicCategoryID");

                    b.ToTable("OlympicCategories");

                    b.HasData(
                        new
                        {
                            OlympicCategoryID = "indoor",
                            Name = "Indoor"
                        },
                        new
                        {
                            OlympicCategoryID = "outdoor",
                            Name = "Outdoor"
                        });
                });

            modelBuilder.Entity("CIS174_TestCoreApp.Models.OlympicGame", b =>
                {
                    b.Property<string>("OlympicGameID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OlympicGameID");

                    b.ToTable("OlympicGames");

                    b.HasData(
                        new
                        {
                            OlympicGameID = "winter",
                            Name = "Winter Olympics"
                        },
                        new
                        {
                            OlympicGameID = "summer",
                            Name = "Summer Olympics"
                        },
                        new
                        {
                            OlympicGameID = "para",
                            Name = "Paralympics"
                        },
                        new
                        {
                            OlympicGameID = "youth",
                            Name = "Youth Olympic Games"
                        });
                });

            modelBuilder.Entity("CIS174_TestCoreApp.Models.OlympicTeam", b =>
                {
                    b.Property<string>("OlympicTeamID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FlagImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OlympicCategoryID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OlympicGameID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("OlympicTeamID");

                    b.HasIndex("OlympicCategoryID");

                    b.HasIndex("OlympicGameID");

                    b.ToTable("OlympicTeams");

                    b.HasData(
                        new
                        {
                            OlympicTeamID = "can",
                            FlagImage = "can.jpg",
                            Name = "Canada Curling",
                            OlympicCategoryID = "indoor",
                            OlympicGameID = "winter"
                        },
                        new
                        {
                            OlympicTeamID = "swe",
                            FlagImage = "swe.jpg",
                            Name = "Sweden Curling",
                            OlympicCategoryID = "indoor",
                            OlympicGameID = "winter"
                        },
                        new
                        {
                            OlympicTeamID = "gbr",
                            FlagImage = "gbr.jpg",
                            Name = "Great Britain Curling",
                            OlympicCategoryID = "indoor",
                            OlympicGameID = "winter"
                        },
                        new
                        {
                            OlympicTeamID = "jam",
                            FlagImage = "jam.jpg",
                            Name = "Jamaica Bobsleigh",
                            OlympicCategoryID = "outdoor",
                            OlympicGameID = "winter"
                        },
                        new
                        {
                            OlympicTeamID = "ita",
                            FlagImage = "ita.jpg",
                            Name = "Italy Bobsleigh",
                            OlympicCategoryID = "outdoor",
                            OlympicGameID = "winter"
                        },
                        new
                        {
                            OlympicTeamID = "jpn",
                            FlagImage = "jpn.jpg",
                            Name = "Japan Bobsleigh",
                            OlympicCategoryID = "outdoor",
                            OlympicGameID = "winter"
                        },
                        new
                        {
                            OlympicTeamID = "deu",
                            FlagImage = "deu.jpg",
                            Name = "Germany Diving",
                            OlympicCategoryID = "indoor",
                            OlympicGameID = "summer"
                        },
                        new
                        {
                            OlympicTeamID = "chn",
                            FlagImage = "chn.jpg",
                            Name = "China Diving",
                            OlympicCategoryID = "indoor",
                            OlympicGameID = "summer"
                        },
                        new
                        {
                            OlympicTeamID = "mex",
                            FlagImage = "mex.jpg",
                            Name = "Mexico Diving",
                            OlympicCategoryID = "indoor",
                            OlympicGameID = "summer"
                        },
                        new
                        {
                            OlympicTeamID = "bra",
                            FlagImage = "bra.jpg",
                            Name = "Brazil Road Cycling",
                            OlympicCategoryID = "outdoor",
                            OlympicGameID = "summer"
                        },
                        new
                        {
                            OlympicTeamID = "nld",
                            FlagImage = "nld.jpg",
                            Name = "Netherlands Road Cycling",
                            OlympicCategoryID = "outdoor",
                            OlympicGameID = "summer"
                        },
                        new
                        {
                            OlympicTeamID = "usa",
                            FlagImage = "usa.jpg",
                            Name = "USA Road Cycling",
                            OlympicCategoryID = "outdoor",
                            OlympicGameID = "summer"
                        },
                        new
                        {
                            OlympicTeamID = "tha",
                            FlagImage = "tha.jpg",
                            Name = "Thailand Archery",
                            OlympicCategoryID = "indoor",
                            OlympicGameID = "para"
                        },
                        new
                        {
                            OlympicTeamID = "ury",
                            FlagImage = "ury.jpg",
                            Name = "Uruguay Archery",
                            OlympicCategoryID = "indoor",
                            OlympicGameID = "para"
                        },
                        new
                        {
                            OlympicTeamID = "ukr",
                            FlagImage = "ukr.jpg",
                            Name = "Ukraine Archery",
                            OlympicCategoryID = "indoor",
                            OlympicGameID = "para"
                        },
                        new
                        {
                            OlympicTeamID = "aut",
                            FlagImage = "aut.jpg",
                            Name = "Austria Canoe Sprint",
                            OlympicCategoryID = "outdoor",
                            OlympicGameID = "para"
                        },
                        new
                        {
                            OlympicTeamID = "pak",
                            FlagImage = "pak.jpg",
                            Name = "Pakistan Canoe Sprint",
                            OlympicCategoryID = "outdoor",
                            OlympicGameID = "para"
                        },
                        new
                        {
                            OlympicTeamID = "zwe",
                            FlagImage = "zwe.jpg",
                            Name = "Zimbabwe Canoe Sprint",
                            OlympicCategoryID = "outdoor",
                            OlympicGameID = "para"
                        },
                        new
                        {
                            OlympicTeamID = "fra",
                            FlagImage = "fra.jpg",
                            Name = "France Breakdancing",
                            OlympicCategoryID = "indoor",
                            OlympicGameID = "youth"
                        },
                        new
                        {
                            OlympicTeamID = "cyp",
                            FlagImage = "cyp.jpg",
                            Name = "Cyprus Breakdancing",
                            OlympicCategoryID = "indoor",
                            OlympicGameID = "youth"
                        },
                        new
                        {
                            OlympicTeamID = "rus",
                            FlagImage = "rus.jpg",
                            Name = "Russia Breakdancing",
                            OlympicCategoryID = "indoor",
                            OlympicGameID = "youth"
                        },
                        new
                        {
                            OlympicTeamID = "fin",
                            FlagImage = "fin.jpg",
                            Name = "Finland Skateboarding",
                            OlympicCategoryID = "outdoor",
                            OlympicGameID = "youth"
                        },
                        new
                        {
                            OlympicTeamID = "svk",
                            FlagImage = "svk.jpg",
                            Name = "Slovakia Skateboarding",
                            OlympicCategoryID = "outdoor",
                            OlympicGameID = "youth"
                        },
                        new
                        {
                            OlympicTeamID = "prt",
                            FlagImage = "prt.jpg",
                            Name = "Portugal Skateboarding",
                            OlympicCategoryID = "outdoor",
                            OlympicGameID = "youth"
                        });
                });

            modelBuilder.Entity("CIS174_TestCoreApp.Models.OlympicTeam", b =>
                {
                    b.HasOne("CIS174_TestCoreApp.Models.OlympicCategory", "OlympicCategory")
                        .WithMany()
                        .HasForeignKey("OlympicCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CIS174_TestCoreApp.Models.OlympicGame", "OlympicGame")
                        .WithMany()
                        .HasForeignKey("OlympicGameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OlympicCategory");

                    b.Navigation("OlympicGame");
                });
#pragma warning restore 612, 618
        }
    }
}