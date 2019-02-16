using System.Collections.Generic;

namespace WorldCup
{
    public interface IGroup
    {
        List<List<int>> GetGroups();
        bool CheckConstraint(List<Team> teams);

    }
}