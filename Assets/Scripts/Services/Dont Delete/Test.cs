
using System.Collections.Generic;
using System;

public static class Test 
{
      public static bool TryAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
{
    if (dictionary == null)
    {
        throw new ArgumentNullException(nameof(dictionary));
    }

    if (!dictionary.ContainsKey(key))
    {
        dictionary.Add(key, value);
        return true;
    }

    return false;
}
}
