using System;
using System.Collections.Generic;

public class Program {
    public static void Main(String[] args) {
        string s = "aabbbc";

        CharFreq(s);
    }

    public static void CharFreq(string s) {
        Dictionary<char, int> map = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++) {
            if (map.ContainsKey(s[i])) {
                map[s[i]]++;
            }
            else {
                map[s[i]] = 1;
            }
        }

        foreach (var pair in map) {
            Console.WriteLine(pair.Key + ":" + pair.Value);
        }
    }
}