/*Maftoul Omar 2019*/

using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace WorldCup
{
        public  static class  Utility
        {
            //Get a value on a dictionary by a key
            public static object GetValueByKey(Dictionary<object, object> collection, object obj)
            {
                //verifying if key is part of dictionary 
                if (collection.ContainsKey(obj))
                    return collection.FirstOrDefault(i => i.Value.Equals(obj)).Value;
                throw new System.NotImplementedException();
            }

            //Get a value on a dictionary by a value
            public static object GetKeyByValue(Dictionary<object, object> collection, object obj)
            {
                //verifying if value is part of dictionary 
                if (collection.ContainsValue(obj))
                    return collection.FirstOrDefault(i => i.Value.Equals(obj)).Key;
                throw new System.NotImplementedException();
            }
            //Get description of an enumerator 
            public static string DescriptionAttr<T>(this T source)
            {
                var fi = source.GetType().GetField(source.ToString());

                var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                    typeof(DescriptionAttribute), false);

                if (attributes.Length > 0)
                    return attributes[0].Description;
             return source.ToString();
            }
    }
}