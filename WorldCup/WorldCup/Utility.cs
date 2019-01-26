/*Maftoul Omar 2019*/

using System.Collections.Generic;
using System.Linq;

namespace WorldCup
{
        public  static class  Utility
        {
        public static object GetValueByKey(Dictionary<object, object> collection, object obj)
            {
                if (collection.ContainsKey(obj))
                    return collection.FirstOrDefault(i => i.Value.Equals(obj)).Value;
                throw new System.NotImplementedException();
            }

            public static object GetKeyByValue(Dictionary<object, object> collection, object obj)
            {
                if (collection.ContainsValue(obj))
                    return collection.FirstOrDefault(i => i.Value.Equals(obj)).Key;
                throw new System.NotImplementedException();
            }
    }
}