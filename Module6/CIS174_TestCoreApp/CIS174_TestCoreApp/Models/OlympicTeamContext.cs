using Microsoft.EntityFrameworkCore;

namespace CIS174_TestCoreApp.Models
{
    public class OlympicTeamContext : DbContext
    {
        public OlympicTeamContext(DbContextOptions<OlympicTeamContext> options) : base(options) { }

        public DbSet<OlympicTeam> OlympicTeams { get; set; } = null!;
        public DbSet<OlympicGame> OlympicGames { get; set;} = null!;
        public DbSet<OlympicCategory> OlympicCategories { get; set;} = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OlympicGame>().HasData(
                new OlympicGame { OlympicGameID = "winter", Name = "Winter Olympics" },
                new OlympicGame { OlympicGameID = "summer", Name = "Summer Olympics" },
                new OlympicGame { OlympicGameID = "para", Name = "Paralympics" },
                new OlympicGame { OlympicGameID = "youth", Name = "Youth Olympic Games"}
            );
            modelBuilder.Entity<OlympicCategory>().HasData(
                new OlympicCategory { OlympicCategoryID = "indoor", Name = "Indoor"},
                new OlympicCategory { OlympicCategoryID = "outdoor", Name = "Outdoor"}
            );
            modelBuilder.Entity<OlympicTeam>().HasData(
                new { OlympicTeamID = "can", Name = "Canada Curling", OlympicGameID = "winter", OlympicCategoryID = "indoor", FlagImage = "can.jpg" },
                new { OlympicTeamID = "swe", Name = "Sweden Curling", OlympicGameID = "winter", OlympicCategoryID = "indoor", FlagImage = "swe.jpg" },
                new { OlympicTeamID = "gbr", Name = "Great Britain Curling", OlympicGameID = "winter", OlympicCategoryID = "indoor", FlagImage = "gbr.jpg" },
                new { OlympicTeamID = "jam", Name = "Jamaica Bobsleigh", OlympicGameID = "winter", OlympicCategoryID = "outdoor", FlagImage = "jam.jpg" },
                new { OlympicTeamID = "ita", Name = "Italy Bobsleigh", OlympicGameID = "winter", OlympicCategoryID = "outdoor", FlagImage = "ita.jpg" },
                new { OlympicTeamID = "jpn", Name = "Japan Bobsleigh", OlympicGameID = "winter", OlympicCategoryID = "outdoor", FlagImage = "jpn.jpg" },
                new { OlympicTeamID = "deu", Name = "Germany Diving", OlympicGameID = "summer", OlympicCategoryID = "indoor", FlagImage = "deu.jpg" },
                new { OlympicTeamID = "chn", Name = "China Diving", OlympicGameID = "summer", OlympicCategoryID = "indoor", FlagImage = "chn.jpg" },
                new { OlympicTeamID = "mex", Name = "Mexico Diving", OlympicGameID = "summer", OlympicCategoryID = "indoor", FlagImage = "mex.jpg" },
                new { OlympicTeamID = "bra", Name = "Brazil Road Cycling", OlympicGameID = "summer", OlympicCategoryID = "outdoor", FlagImage = "bra.jpg" },
                new { OlympicTeamID = "nld", Name = "Netherlands Road Cycling", OlympicGameID = "summer", OlympicCategoryID = "outdoor", FlagImage = "nld.jpg" },
                new { OlympicTeamID = "usa", Name = "USA Road Cycling", OlympicGameID = "summer", OlympicCategoryID = "outdoor", FlagImage = "usa.jpg" },
                new { OlympicTeamID = "tha", Name = "Thailand Archery", OlympicGameID = "para", OlympicCategoryID = "indoor", FlagImage = "tha.jpg" },
                new { OlympicTeamID = "ury", Name = "Uruguay Archery", OlympicGameID = "para", OlympicCategoryID = "indoor", FlagImage = "ury.jpg" },
                new { OlympicTeamID = "ukr", Name = "Ukraine Archery", OlympicGameID = "para", OlympicCategoryID = "indoor", FlagImage = "ukr.jpg" },
                new { OlympicTeamID = "aut", Name = "Austria Canoe Sprint", OlympicGameID = "para", OlympicCategoryID = "outdoor", FlagImage = "aut.jpg" },
                new { OlympicTeamID = "pak", Name = "Pakistan Canoe Sprint", OlympicGameID = "para", OlympicCategoryID = "outdoor", FlagImage = "pak.jpg" },
                new { OlympicTeamID = "zwe", Name = "Zimbabwe Canoe Sprint", OlympicGameID = "para", OlympicCategoryID = "outdoor", FlagImage = "zwe.jpg" },
                new { OlympicTeamID = "fra", Name = "France Breakdancing", OlympicGameID = "youth", OlympicCategoryID = "indoor", FlagImage = "fra.jpg" },
                new { OlympicTeamID = "cyp", Name = "Cyprus Breakdancing", OlympicGameID = "youth", OlympicCategoryID = "indoor", FlagImage = "cyp.jpg" },
                new { OlympicTeamID = "rus", Name = "Russia Breakdancing", OlympicGameID = "youth", OlympicCategoryID = "indoor", FlagImage = "rus.jpg" },
                new { OlympicTeamID = "fin", Name = "Finland Skateboarding", OlympicGameID = "youth", OlympicCategoryID = "outdoor", FlagImage = "fin.jpg" },
                new { OlympicTeamID = "svk", Name = "Slovakia Skateboarding", OlympicGameID = "youth", OlympicCategoryID = "outdoor", FlagImage = "svk.jpg" },
                new { OlympicTeamID = "prt", Name = "Portugal Skateboarding", OlympicGameID = "youth", OlympicCategoryID = "outdoor", FlagImage = "prt.jpg" }
            );
        }
    }
}
