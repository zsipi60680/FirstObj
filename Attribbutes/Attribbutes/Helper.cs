using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Attribbutes
{
    public static class Helper
    {
        public static bool IsValidLen<T>(this T obj) where T : class
        {
            Type type = obj.GetType();
            var props = type.GetProperties().Where(p => p.PropertyType.Name == "String");

            foreach (var prop in props)
            {
                StringAttribbute attribute = prop.GetCustomAttribute<StringAttribbute>();
                //int max = attribute.
                string s = prop.GetValue(obj).ToString();
                //if (s.Length > max)
                    return false;
            }

            return true;
        }
    }
}
