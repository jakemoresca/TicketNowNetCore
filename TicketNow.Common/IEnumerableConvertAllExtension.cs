using System;
using System.Collections.Generic;

namespace TicketNow.Common
{
    public static class IEnumerableConvertAllExtension
    {
        public static IReadOnlyList<TResult> ConvertAll<T, TResult>(this IEnumerable<T> enumerable, Func<T, TResult> convertFunction)
        {
            var list = new List<TResult>();

            foreach (var item in enumerable)
            {
                list.Add(convertFunction(item));
            }

            return list.AsReadOnly();
        }
    }
}
