using System;

public class CountUpperCaseLowerCaseDigits {
    public static void Main(String[] args) {
        string s = "CSharp2026";

        CountFreq(s);
    }

    public static void CountFreq(string s) {

        int upCtr = 0;
        int lowCtr = 0;
        int digCtr = 0;

        for (int i = 0; i < s.Length; i++) {
            char c = s[i];

            if (char.IsLower(c)) lowCtr++;
            if (char.IsUpper(c)) upCtr++;
            if (char.IsDigit(c)) digCtr++;
        }

        Console.WriteLine("Uppercase: " + upCtr + "\n" + 
                          "Lowercase: " + lowCtr + "\n" + 
                          "Digits: " + digCtr);

    }
}