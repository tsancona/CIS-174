namespace CIS174_TestCoreApp.Models
{
    public class OlympicTeam
    {
        public string OlympicTeamID { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public OlympicGame OlympicGame { get; set; } = null!;
        public OlympicCategory OlympicCategory { get; set; } = null!;
        public string FlagImage { get; set; } = string.Empty;
    }
}
