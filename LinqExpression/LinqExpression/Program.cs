using System;
using System.Collections.Generic;

namespace LinqExpression
{
    static class Program
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> list, Func<T, T> function)
        {
            foreach(var item in list)
            {
                yield return function(item);
            }
        }


    }
}
