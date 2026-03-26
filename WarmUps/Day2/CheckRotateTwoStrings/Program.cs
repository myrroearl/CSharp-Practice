using System;

public class Program {
    public static void Main(String[] args) {

        string x = "abcd";
        string y = "acbd";

        Console.WriteLine(CheckRot(x, y));
    }

    public static string CheckRot(string x, string y) {

        if (x.Length != y.Length) {
            return "NO";
        }

        string temp = y + y;
        if (temp.Contains(x)) {
            return "YES";
        }

        return "NO";
    }
}