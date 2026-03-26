using System;
using System.Collections.Generic;
public class Program {
    public static void Main(String[] args) {

        string s = "aabcccccaaa";

        Console.WriteLine(StringCompress(s));

    }

    public static string StringCompress(string s) {

        string x = "";
        Dictionary<char, int> map = new Dictionary<char, int>();
        char prev = s[0];
        for (int i = 0; i < s.Length; i++) {
            if (map.ContainsKey(s[i])) {
                map[s[i]]++;
            }
            else {

                if (i > 0) {
                    x += prev + "" + map[prev]; 
                    map.Clear();
                }
                
                map[s[i]] = 1;
                prev = s[i];
                
            }
        }

        if (map.Count > 0) {
            x += s[s.Length-1] + "" + map[s[s.Length-1]];
        }

        return x;

    }
}