using System;
using System.Collections.Generic;

class Permutations
{
    public static List<string> SinglePermutations(string s)
    {
        List<string> result = new List<string>();
        bool[] used = new bool[s.Length]; 
        Backtrack("", s, used, result);
        return result;
    }

    private static void Backtrack(string current, string s, bool[] used, List<string> result)
    {
        if (current.Length == s.Length)
        {
            if (!result.Contains(current))
                result.Add(current);
            return;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (used[i]) continue;
            used[i] = true;
            Backtrack(current + s[i], s, used, result);
            used[i] = false;
        }
    }
}
