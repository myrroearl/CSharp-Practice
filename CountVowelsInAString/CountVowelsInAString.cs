using System;

public class CountVwelsInAString {
    public static void Main(String[] args) {

        string s = "myrro";

        Console.WriteLine(countVowels(s));
    }

    public static int countVowels(string s) {

        int ctr = 0;    

        s = s.ToLower();
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u') {
                ctr++;
            }
        }

        return ctr;
    }
}

