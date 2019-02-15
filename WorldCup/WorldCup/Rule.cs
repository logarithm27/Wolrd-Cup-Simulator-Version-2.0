
namespace WorldCup
{
    public static class Rule
    {
        public  const int TeamsPerPot = 8;
        public const int MaxGroups = 8;
        public const int MaxPots = 4;
        public const int MxNumOfConfederations = 6;
     

        public enum MaxTeamsPerConfederation
        {
            Asia = 5,
            Africa =5,
            NorthAndCentralAmerica=2,
            SouthAmerica=6,
            Europe=14
        }

        public enum MaxTeamsPerGroup
        {
            Asia =1,
            Africa=1,
            NorthAndCentralAmerica=1,
            SouthAmerica=1,
            Europe=2
        }
    }

}
