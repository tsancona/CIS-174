namespace CIS174_TestCoreApp.Models
{
    public class OlympicSession
    {
        private const string TeamsKey = "myteams";
        private const string CountKey = "teamcount";
        private const string GameKey = "game";
        private const string CatKey = "cat";

        private ISession session { get; set; }
        public OlympicSession(ISession session)
        {
            this.session = session;
        }

        public void SetMyTeams(List<OlympicTeam> teams)
        {
            session.SetObject(TeamsKey, teams);
            session.SetInt32(CountKey, teams.Count);
        }

        public List<OlympicTeam> GetMyTeams()
        {
            return session.GetObject<List<OlympicTeam>>(TeamsKey) ?? new List<OlympicTeam>();
        }

        public int? GetMyTeamCount()
        {
            return session.GetInt32(CountKey);
        }

        public void SetActiveGame(string activeGame)
        {
            session.SetString(GameKey, activeGame);
        }

        public string GetActiveGame()
        {
            return session.GetString(GameKey) ?? string.Empty;
        }

        public void SetActiveCat(string activeCat)
        {
            session.SetString(CatKey, activeCat);
        }

        public string GetActiveCat()
        {
            return session.GetString(CatKey) ?? string.Empty;
        }

        public void RemoveMyTeams()
        {
            session.Remove(TeamsKey);
            session.Remove(CountKey);
        }
    }
}
