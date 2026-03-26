using System;

public class Program {

    public static void Main(String[] args) {

        string s = "Hello World check";

        Console.WriteLine(ReplaceSpaces(s));
    }

    public static string ReplaceSpaces(string s) {

        

        return s.Replace(" ", "-");
    }
}