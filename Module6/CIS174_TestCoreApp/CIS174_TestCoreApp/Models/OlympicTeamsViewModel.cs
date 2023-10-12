namespace CIS174_TestCoreApp.Models
{
    public class OlympicTeamsViewModel
    {
        public string ActiveGame { get; set; } = "all";
        public string ActiveCat { get; set; } = "all";
        public List<OlympicTeam> OlympicTeams { get; set;} = new List<OlympicTeam>();
        public List<OlympicGame> OlympicGames { get; set; } = new List<OlympicGame>();
        public List<OlympicCategory> OlympicCategories { get; set;} = new List<OlympicCategory>();

        public string CheckActiveGame(string game)
        {
            return game.ToLower() == ActiveGame.ToLower() ? "active" : "";
        }

        public string CheckActiveCategory(string category)
        {
            return category.ToLower() == ActiveCat.ToLower() ? "active" : "";
        }
    }
}
