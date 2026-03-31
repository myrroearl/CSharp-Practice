using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

public class Program {

    public static void Main(String[] args) {

        string s = "ba";
        string t = "aa";

        Console.WriteLine(MinWindowSubstring(s, t));
    }

    public static int MinWindowSubstring(string s, string t) {
        int min = int.MaxValue;
        bool flag = false;

        for (int i = 0; i < s.Length; i++) {
            string cur = "";
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int j = 0; j < t.Length; j++) {
                if (map.ContainsKey(t[j])) {
                    map[t[j]]++;
                }
                else {
                    map[t[j]] = 1;
                }
            } 

            for (int j = i; j < s.Length; j++) {
                cur += s[j];
                
                if (map.ContainsKey(s[j])) {
                    map[s[j]]--;
                    if (map[s[j]] == 0) {
                        map.Remove(s[j]);
                    }
                }

                if (map.Count == 0) {
                    min = Math.Min(min, j - i + 1);
                    flag = true;
                    break;
                }
                
            }
        }

        if (flag == false) {
            return 0;
        }

        return min;

    }

}