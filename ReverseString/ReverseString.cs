using System;

public class ReverseString {
    public static void Main(String[] args) {

        string s = "competition";

        Console.WriteLine(revString(s));
    }

    public static string revString(string s) {
    
        string x = "";

        for (int i = s.Length - 1; i >= 0; i--) {
            x += s[i];
        }

        return x;
    }
}