using System;
using System.Collections.Generic;

public class RemoveDuplicateCharacters {
    public static void Main(String[] args) {

        string s = "banana";

        Console.WriteLine(RemoveDupChar(s));
    }

    public static string RemoveDupChar(string s) {

        HashSet<char> set = new HashSet<char>();

        string x = "";

        for (int i = 0; i < s.Length; i++) {

            if (!set.Contains(s[i])) {
                x += s[i];
            }
            set.Add(s[i]);
        }

        return x;
    }
}