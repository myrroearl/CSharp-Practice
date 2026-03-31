using System;

public class Program {
    public static void Main(String[] args) {
        int a = 2;
        int b = 100;
        int m = 1000000007;

        Console.WriteLine(Math.Pow(a, b) % m);
    }
}