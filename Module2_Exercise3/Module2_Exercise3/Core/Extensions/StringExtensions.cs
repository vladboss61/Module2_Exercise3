namespace Module2_Exercise3.Core.Extensions;

internal static class StringExtensions
{
    public static int CharCount(this string str, char c)
    {
        int counter = 0;
        foreach (var symbol in str)
        {
            if (symbol == c)
            {
                counter++;
            }
        }

        return counter;
    }

    public static string Reverse(this string str)
    {
        char[] cArray = str.ToCharArray();
        string reverse = string.Empty;

        for (int i = cArray.Length - 1; i >= 0; i--)
        {
            reverse += cArray[i];
        }
        return reverse;
    }
}
