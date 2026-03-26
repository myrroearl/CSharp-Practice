using System;

public class Programming {
    public static void Main(String[] args) {
        string s = "I love C Sharp";

        Console.WriteLine(ReplaceSpaces(s));
    }

    public static string ReplaceSpaces(string s) {
        
        s = s.Replace(" ", "-");

        return s;
    }
}