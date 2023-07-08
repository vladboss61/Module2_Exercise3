using System;

namespace Module2_Exercise3.Core.Extensions;

internal static class ArrayExtensions
{
    public static bool IsEmpty(this int[] array)
    {
        return array.Length == 0;
    }

    public static void Clear(this int[] array)
    {
        Array.Clear(array);
    }
}
