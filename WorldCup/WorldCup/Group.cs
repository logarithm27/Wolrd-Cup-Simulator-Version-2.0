using System.Collections.Generic;

namespace WorldCup
{
    public class Group : IGroup
    {
        private List<List<Team>> _getGroups;
        private List<List<Team>> GetGroup() => _getGroups;
        public List<List<int>> GetGroups()
        {
            /*TO DO*/
            throw new System.NotImplementedException();
        }

        public bool CheckConstraint(List<Team> teams)
        {
            throw new System.NotImplementedException();
        }

    }
}