using System.Collections.Generic;

namespace WorldCup
{
    public interface ITeam
    {
        string GetConfederation(Team team);
        int GetMaxAcceptedTeamsByConfederation(Team team, List<List<int>> pots);
        bool TeamIsAllowed(Team team);
    }
}