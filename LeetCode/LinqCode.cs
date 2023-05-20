using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Linq
    {
        public static IEnumerable<T> FindDuplicates<T>(this IEnumerable<T> list)
        {
            var hashSet = new HashSet<T>();
            foreach (var item in list)
            {
                if (hashSet.Contains(item))
                {
                    yield return item;
                }
                hashSet.Add(item);
            }


        }

    }

}
