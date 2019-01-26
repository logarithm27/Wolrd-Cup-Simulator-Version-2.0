/*Maftoul Omar 2019*/

using System.Collections.Generic;
using System.Linq;

namespace WorldCup
{
        public  static class  Utility
        {
        public static object DictionarySearchByKey(Dictionary<object, object> collection, object obj)
            {
                if (collection.ContainsKey(obj))
                    return collection.FirstOrDefault(i => i.Key.Equals(obj));
                throw new System.NotImplementedException();
            }

            public static object DictionarySearchByValue(Dictionary<object, object> collection, object obj)
            {
                if (collection.ContainsValue(obj))
                    return collection.FirstOrDefault(i => i.Value.Equals(obj));
                throw new System.NotImplementedException();
            }
    }
}