using System;
using System.Collections.Generic;

public class Programming {
    public static void Main(String[] args) {
        string s = "swiss";

        Console.WriteLine(FirstNon(s));
    }

    public static char FirstNon(string s) {

        Dictionary<char, int> map = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++) {
            if (map.ContainsKey(s[i])) {
                map[s[i]]++;
            }
            else {
                map[s[i]] = 1;
            }
        }

        for (int i = 0; i < s.Length; i++) {
            if (map[s[i]] == 1) {
                return s[i];
            }
        }

        return ' ';
    }
}