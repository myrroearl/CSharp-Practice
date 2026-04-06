using System;
using System.Collections.Generic;
using System.Dynamic;

public class Program {
    public static void Main(String[] args) {
        string s = "pwwkew";

        Console.WriteLine(LongestSubstringWithoutRepeatingCharacters(s));
    }

    public static int LongestSubstringWithoutRepeatingCharacters(string s) {
        int max = 0;
        int start = 0;
        int end = 0;

        HashSet<char> set = new HashSet<char>();

        while (end < s.Length) {

            if (set.Contains(s[end])) {
                while (set.Contains(s[end])) {
                set.Remove(s[start]);
                start++;
            }
            }
            else {
                set.Add(s[end]);
                end++;
            }
            

            
            
            max = Math.Max(max, end - start);

            
        }


        return max;
    }
}