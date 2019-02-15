namespace WorldCup
{
    public interface ITeam
    {
         string GetConfederation();
        int GetMaxAcceptedTeamsByConfederation();
        bool TeamIsAllowed();
    }
}