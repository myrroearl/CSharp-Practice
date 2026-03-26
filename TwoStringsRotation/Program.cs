using System;

public class Program {
    public static void Main(String[] args) {
        string x = "abcd";
        string y = "acbd";

        CheckRotation(x, y);
        
    }

    public static void CheckRotation(string x, string y) {

        y = y + y;

        if (y.Contains(x)) {
            Console.WriteLine("YES");
        }
        else {
            Console.WriteLine("NO");
        }
    }
}