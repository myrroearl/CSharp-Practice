using System;

public class Program {

    public static void Main(String[] args) {

        string s = "banana";
        char c = 'a';

        Console.WriteLine(CountOccurences(s,c));

    }

    public static int CountOccurences(string s, char c) {

        int ctr = 0;
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == c) {
                ctr++;
            }
        }

        return ctr;
    }

}