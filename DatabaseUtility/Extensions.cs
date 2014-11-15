using System;
using System.Collections.Generic;

namespace DatabaseUtility {
    public static class Extensions {
        public static void Foreach<T>(this IEnumerable<T> items, Action<T> action) {
            foreach (T item in items) {
                action(item);
            }
        }
    }
}
