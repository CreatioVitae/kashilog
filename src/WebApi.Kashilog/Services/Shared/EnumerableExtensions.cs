using System.Collections.Generic;
using System.Linq;

namespace WebApi.Kashilog.Services.Shared {
    public static class EnumerableExtensions {
        public static List<T> AsList<T>(this IEnumerable<T> source) where T : class =>
            (source is List<T>) ? (List<T>)source : source.ToList();
    }
}