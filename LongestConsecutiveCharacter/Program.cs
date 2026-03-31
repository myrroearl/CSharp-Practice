using System;

public class Program {

    public static void Main(String[] args) {

        string s = "aabbbbaa";
    
        Console.WriteLine(LongestConsec(s));
    }

    public static int LongestConsec(string s) {

        int max = 1;
        int ctr = 1;

        for (int i = 1; i < s.Length; i++) {
            if (s[i] != s[i-1]) {
                ctr = 0;
            }
            ctr++;

            max = Math.Max(max, ctr);
        }

        return max;
    }

}