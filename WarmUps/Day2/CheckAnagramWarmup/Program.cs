using System;
using System.Collections.Generic;

public class Programming {
    public static void Main(String[] args) {

        string x = "listen";
        string y = "silent";

        Console.WriteLine(CheckAnagram(x, y));

    }

    public static string CheckAnagram(string x, string y) {

        if (x.Length != y.Length) {
            return "NO";
        }
        
        Dictionary<char, int> map = new Dictionary<char, int>();

        for (int i = 0; i < x.Length; i++) {
            if (map.ContainsKey(x[i])) {
                map[x[i]]++;
            }
            else {
                map[x[i]] = 1;
            }
        }

        for (int i = 0; i < y.Length; i++) {
            if (map.ContainsKey(y[i])) {
                if (map[y[i]] == 0) {
                    return "NO";
                }
                map[y[i]]--;
            }
            else {
                return "NO";
            }
        }

        return "YES";

    }
}