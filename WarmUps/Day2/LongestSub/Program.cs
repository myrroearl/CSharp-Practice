using System;
using System.Collections.Generic;

public class Program {

    public static void Main(String[] args) {
        string s = "bbbbb";
        
        Console.WriteLine(LongestSub(s));
    }

    public static int LongestSub(string s) {

        HashSet<char> set = new HashSet<char>();
        int start = 0;
        int end = 0;
        int max = 0;

        while (end < s.Length) {

            if (set.Contains(s[end])) {
                set.Remove(s[start]);
                start++;
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