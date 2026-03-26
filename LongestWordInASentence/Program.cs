using System;

public class Program {
    public static void Main(String[] args) {

        string s = "This is a simple test";

        Console.WriteLine(LongestWord(s));
    }

    public static string LongestWord(string s) {

        string x = "";
        int max = 0;
        string[] arr = s.Split();

        for (int i = 0; i < arr.Length; i++) {
            if (arr[i].Length > max) {
                x = arr[i];
                max = arr[i].Length;
            }
        }

        return x;
    }
}