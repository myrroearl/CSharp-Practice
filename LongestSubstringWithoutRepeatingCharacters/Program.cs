using System;
using System.Collections.Generic;

public class Program {
    public static void Main(String[] args) {
        string s = "bbbbb";

        Console.WriteLine(LongestSubstringWithoutRepeatingCharacters(s));
    }

    public static int LongestSubstringWithoutRepeatingCharacters(string s) {

        HashSet<char> set = new HashSet<char>();
        int max = 0;

        for (int i = 0; i < s.Length; i++) {

            if (set.Contains(s[i])) {
                max = Math.Max(max, set.Count);
                set.Clear();
                set.Add(s[i]);
            }
            else {
                set.Add(s[i]);
            }
        }

        return max;
    }
}