/*Maftoul Omar 2019*/

using System.Collections.Generic;

namespace WorldCup
{
        public  interface IUtility
        {
            object DictionarySearchByKey(Dictionary<object,object> collection,object obj);
            bool DictionaryContains(Dictionary<object, object> collection,object obj);
            object DictionarySearchByValue(Dictionary<object, object> collection,object obj);
        }
}