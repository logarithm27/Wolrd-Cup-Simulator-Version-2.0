/*Maftoul Omar 2019*/
using System.ComponentModel;

namespace WorldCup
{
    public struct Confederation
    {
        public enum ConfederationCode
        {
            [Description("Asia")]
            Asia=1,
            [Description("Africa")]
            Africa =2,
            [Description("Europe")]
            Europe =3,
            [Description("North America")]
            NorthAmerica =4,
            [Description("Oceania")]
            Oceania =5,
            [Description("South America")]
            SouthAmerica =6
        }
    }
}