using System.Collections.Generic;

namespace WorldCup
{
    public abstract class AUtility : IUtility
    {
        public bool DictionaryContains(Dictionary<object, object> collection,object obj)
        {
            
        }

        public object DictionarySearchByKey(Dictionary<object, object> collection,object obj)
        {
            throw new System.NotImplementedException();
        }

        public object DictionarySearchByValue(Dictionary<object, object> collection,object obj)
        {
            throw new System.NotImplementedException();
        }
    }
}