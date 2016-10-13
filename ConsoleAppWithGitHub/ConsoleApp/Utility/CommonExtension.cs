using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Utility
{
    public static class CommonExtension
    {
        public static TResult[] ConvertArray<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> func)
        {
            return source == null ? null : source.Select(func).ToArray<TResult>();
        }

        public static IEnumerable<TSource> ConvertEnumerable<TSource>(this IQueryable<TSource> source)
        {
            return source == null ? null : source.AsEnumerable();
        }

        public static IEnumerable<TSource> DefaultIfNull<TSource>(this IQueryable<TSource> source)
        {
            return source == null ? default(IEnumerable<TSource>) : source.AsEnumerable();
        }

        public static int? SumIfNotNull<TSource>(this IQueryable<TSource> source, Func<TSource, int?> func)
        {
            return source == null ? null : source.Sum(func);
        }

        public static TResult[] DeserializeArraySafe<TResult>(this string jsonString)
        {
            return string.IsNullOrEmpty(jsonString) ? default(TResult[]) : JsonConvert.DeserializeObject<TResult[]>(jsonString);
        }

        public static string SerializeStringSafe<TSource>(this TSource[] sources)
        {
            return sources == null ? String.Empty : JsonConvert.SerializeObject(sources);
        }
    }
}
