/*Maftoul Omar 2019*/

using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

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
            public static string DescriptionAttr<T>(this T source)
            {
                FieldInfo fi = source.GetType().GetField(source.ToString());

                DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                    typeof(DescriptionAttribute), false);

                if (attributes.Length > 0)
                    return attributes[0].Description;
             return source.ToString();
            }
    }
}