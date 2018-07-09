using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    static class StringAdd
    {
        public static string BackWard(this string str)
        {
            
            char[] data = str.ToCharArray();
            Array.Reverse(data);

            return new string(data);
        }

        public static string Them(this string str, string addition)
        {
            return (str + addition);
        }

        public static IEnumerable<TSource> taolaobidao<TSource>(this IEnumerable<TSource> source)
        {
            
            return null;
        }
        
        public static T[] Where<T>(this GEnericClass2<T> source, Func<T, bool> predicate)
        {
            List<T> res = new List<T>();

            foreach(T item in source.Datas)
            {
                if (predicate(item))
                    res.Add(item);
            }

            return res.ToArray();
        }
    }
}
