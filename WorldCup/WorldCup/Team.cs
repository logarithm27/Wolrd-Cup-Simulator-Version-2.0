using System.Collections.Generic;

namespace WorldCup
{
    public class Team : ITeam
    {
        private string _teamName;
        public string TeamName() => _teamName;
        private string _team_s_confederation;
        public string TeamSConfederation() => _team_s_confederation;

        private string _teamFlag;
        public string TeamFlag() => _teamFlag;
        public string GetConfederation(Team team)
        {
            return string.Empty;
            /*TO DO*/
        }

        public int GetMaxAcceptedTeamsByConfederation(Team team, List<List<int>> pots)
        {
            return -1;
            /*TO DO*/
        }

        public bool TeamIsAllowed(Team team)
        {
            return false;
            /*TO DO*/
        }
    }
}